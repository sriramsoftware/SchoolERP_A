using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Summary description for Helper
/// </summary>
public class Helper
{
	public Helper()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    #region Encrypt Password
    public string encryptPassword(string sData)
    {
        string encodedData = "";
        try
        {
            byte[] encData_byte = new byte[sData.Length];
            encData_byte = System.Text.Encoding.UTF8.GetBytes(sData);
            encodedData = Convert.ToBase64String(encData_byte);
        }
        catch (Exception ex)
        {
            throw new Exception("Error in base64Encode" + ex.Message);
        }
        return encodedData;
    }
    #endregion

    #region Decrypt Password
    public string decryptPassword(string sData)
    {
        string result = "";
        try
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(sData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            result = new string(decoded_char);
        }
        catch
        {
        }
        return result;
    }
    #endregion    

    #region  --- Encrypt decrecypt password

    public static string encrypPassword(string sData)
    {
        string encodedData = "";
        try
        {
            byte[] encData_byte = new byte[sData.Length];

            encData_byte = System.Text.Encoding.UTF8.GetBytes(sData);

            encodedData = Convert.ToBase64String(encData_byte);
        }

        catch (Exception ex)
        {
            //throw new Exception("Error in base64Encode" + ex.Message);
        }
        return encodedData;
    }

    public static string decryptPassword1(string sData)
    {
        string result = "";
        try
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();

            System.Text.Decoder utf8Decode = encoder.GetDecoder();

            byte[] todecode_byte = Convert.FromBase64String(sData);

            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);

            char[] decoded_char = new char[charCount];

            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);

            result = new string(decoded_char);


        }
        catch
        {

        }
        return result;
    }


    #endregion

    public int SetPane(AjaxControlToolkit.Accordion acc, string PaneID)
    {
        int Index = 0;
        foreach (AjaxControlToolkit.AccordionPane pane in acc.Panes)
        {
            if (pane.Visible == true)
            {
                if (pane.ID == PaneID)
                {
                    acc.SelectedIndex = Index;
                    break;
                }
                Index++;
            }
        }
        return Index;
    }

}