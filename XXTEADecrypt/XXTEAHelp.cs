using System;
using System.Collections.Generic;
using System.Text;

public class XXTEAHelp
{
    /// <summary>
    /// 确定加密的密钥,加密字节流
    /// </summary>
    /// <param name="data">待加密的字节流</param>
    /// <param name="data_len">待加密的字节长度</param>
    /// <param name="key">加密的密钥字节流</param>
    /// <param name="key_len">密钥的长度</param>
    /// <param name="ret_length">加密后返回的字节流长度</param>
    /// <returns>返回加密后的字节流</returns>
    public byte[] xxtea_encrypt(byte[] data, uint data_len, byte[] key, uint key_len, out uint ret_length)
	{
		byte[] result;
		
		ret_length = 0;
		/*密钥长度小于16字节的用'\0'填充*/
		if (key_len < 16) {
			byte[] key2 = fix_key_length(key, key_len);
			result = do_xxtea_encrypt(data, data_len, key2, out ret_length);
			//free(key2);
		}
		else
		{
			result = do_xxtea_encrypt(data, data_len, key, out ret_length);
		}
		
		return result;
	}
	
	//将不满16位的密钥后面用'\0'填充
	private  byte[] fix_key_length(byte[] key, uint key_len)
	{
		byte[] tmp = new byte[16];
		Array.Copy(key, tmp, key_len);
		for(uint i = key_len; i < tmp.Length; i++)
		{
			tmp[i] = 0;		//剩余字节用'\0'填充
		}
		return tmp;
	}
    /// <summary>
    /// 确定加密使用的v.k 在对其转换为uint32流后加密,在转换为字节流
    /// </summary>
    /// <param name="data">待加密的字节流</param>
    /// <param name="len">加密的字节长度</param>
    /// <param name="key">加密的密钥字节流</param>
    /// <param name="ret_len">返回加密后的字节流长度</param>
    /// <returns>返回加密后的字节流</returns>
    private byte[] do_xxtea_encrypt(byte[] data, uint len, byte[] key, out uint ret_len) {
		byte[] result;
		uint[] v, k;
		//xxtea_long *v, *k, v_len, k_len;
		uint v_len, k_len;
		v = xxtea_to_long_array(data, len, 1, out v_len);
		k = xxtea_to_long_array(key, 16, 0, out k_len);
		xxtea_long_encrypt(ref v, v_len, ref k);
		result = xxtea_to_byte_array(v, v_len, 0, out ret_len);		
		return result;
	}
    /// <summary>
    /// 将字节流转换为uint流
    /// </summary>
    /// <param name="data">待转换的字节流</param>
    /// <param name="len">转换字节流的长度</param>
    /// <param name="include_length">开关,等于1则分配(len % 4) ? len / 4 + 1 : len / 4 + 1 + 1个元素空间,
    /// 等于0则分配 (len % 4) ? len / 4 : len / 4 + 1个元素空间</param>
    /// <param name="ret_len">返回转换后的数组长度</param>
    /// <returns>返回转换后的uint数组流</returns>
    private uint[] xxtea_to_long_array(byte[] data, uint len, int include_length, out uint ret_len) {
		//xxtea_long i, n, *result;
		uint i, n;
		uint[] result;

		n = len >> 2;	
	
		n = (((len & 3) == 0) ? n : n + 1); 	//确保最后一个是否为0
		if (include_length == 1) {
			//申请n + 1个元素,最后一个元素保存原字节流的长度
			result = new uint[(n + 1) << 2];
			result[n] = len;
			ret_len = n + 1;
		} else {
			result = new uint[n << 2];
			ret_len = n;
		}
		for (i = 0; i < len; i++) {
           

			result[i >> 2] |= (uint)data[i]<< (int)((i & 3) << 3);
		}
		
		return result;
	}
    /*#define XXTEA_MX (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z)
	  #define XXTEA_DELTA 0x9e3779b9*/
    /// <summary>
    /// XXTEA算法加密uint流
    /// </summary>
    /// <param name="v">返回算法加密后的uint流</param>
    /// <param name="len">加密前的uint流长度</param>
    /// <param name="k">参与运算的k密钥</param>
    private void xxtea_long_encrypt(ref uint[] v, uint len, ref uint[] k)
	{
		uint n = len - 1;
		uint z = v[n], y = v[0], p, q = 6 + 52 / (n + 1), sum = 0, e;
		if (n < 1) {
			return;
		}
		while (0 < q--) {
			sum += 0x9e3779b9;
			e = sum >> 2 & 3;
			/*当前数组元素与下个数组元素参与运算*/
			for (p = 0; p < n; p++) {
				y = v[p + 1];
				z = v[p] += (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z);
			}
			/*第一个数组元素与最后一个数组元素运算*/
			y = v[0];
			z = v[n] += (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z);
		}
	}
    /*#define XXTEA_MX (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z)
	  #define XXTEA_DELTA 0x9e3779b9*/
    /// <summary>
    /// XXTEA算法解密uint流
    /// </summary>
    /// <param name="v">返回算法解密后的uint流</param>
    /// <param name="len">密前的uint流长度</param>
    /// <param name="k">参与运算的密钥</param>
    private void xxtea_long_decrypt(ref uint[] v, uint len, ref uint[] k)
	{
		uint n = len - 1;
		uint z = v[n], y = v[0], p, q = 6 + 52 / (n + 1), sum = q * 0x9e3779b9, e;
		if (n < 1) {
			return;
		}
		while (sum != 0) {
			e = sum >> 2 & 3;
			for (p = n; p > 0; p--) {
				z = v[p - 1];
				y = v[p] -= (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z);
			}
			z = v[n];
			y = v[0] -= (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z);
			sum -= 0x9e3779b9;
		}
	}
    /// <summary>
    /// uint流转换为字节流
    /// </summary>
    /// <param name="data">待转换的uint流</param>
    /// <param name="len">待转换的uint流的长度</param>
    /// <param name="include_length">包含长度开关</param>
    /// <param name="ret_len">返回转换后的字节流长度</param>
    /// <returns>回转换后的字节流</returns>
    private byte[] xxtea_to_byte_array(uint[] data, uint len, int include_length, out uint ret_len) {
		uint i, n, m;
		byte[] result;
        ret_len = 0;
		n = len << 2;
		if (include_length == 1) {
			m = data[len - 1];
			if ((m < n - 7) || (m > n - 4)) return null;
			n = m;
		}
        //此处修改了源码
		result = new byte[n];
		for (i = 0; i < n; i++) {
			result[i] = (byte)((data[i >> 2] >> (int)((i & 3) << 3)) & 0xff);
		}
		//result[n] = 0;
		ret_len = n;
		
		return result;
	}
	/*******************************decrypt****************************************/
	/// <summary>
    /// 解密字节流
    /// </summary>
    /// <param name="data">待解密的字节流</param>
    /// <param name="data_len">解密的字节长度</param>
    /// <param name="key">解密需要的密钥</param>
    /// <param name="key_len">密钥的长度</param>
    /// <param name="ret_length">返回解密后的长度</param>
    /// <returns></returns>
    public byte[] xxtea_decrypt(byte[] data, uint data_len, byte[] key, uint key_len, out uint ret_length)
	{
		byte[] result;
		
		ret_length = 0;
		
		if (key_len < 16) {
			byte[] key2 = fix_key_length(key, key_len);
			result = do_xxtea_decrypt(data, data_len, key2, out ret_length);
			
		}
		else
		{
			result = do_xxtea_decrypt(data, data_len, key, out ret_length);
		}
		
		return result;
	}
	/// <summary>
    /// XXTEA解密字节流
    /// </summary>
    /// <param name="data">待解密的字节流</param>
    /// <param name="len">解密的字节流长度</param>
    /// <param name="key">解密的密钥</param>
    /// <param name="ret_len">返回解密后的长度</param>
    /// <returns></returns>
    private  byte[] do_xxtea_decrypt(byte[] data, uint len, byte[] key, out uint ret_len) {
		byte[] result;
		uint[] v, k;
		uint v_len, k_len;
		
		v = xxtea_to_long_array(data, len, 0, out v_len);	//确定v的值
		k = xxtea_to_long_array(key, 16, 0, out k_len);	//确定k的值
		xxtea_long_decrypt(ref v, v_len, ref k);
		result = xxtea_to_byte_array(v, v_len, 1, out ret_len);
		return result;
	}
	
}