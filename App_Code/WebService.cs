using System;
using System.Web;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml;
using System.Text;
using System.IO;
using AjaxControlToolkit;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[System.Web.Script.Services.ScriptService()]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }


    [WebMethod]

    [System.Web.Script.Services.ScriptMethod]

    public CascadingDropDownNameValue[] BindCountry(string knownCategoryValues, string category)
    {
        DataTable dtCountry = new DataTable();
        dtCountry = TMSCountry.GetSearch(null, null, 1).Tables[0];

        List<CascadingDropDownNameValue> cascadingValues = new List<CascadingDropDownNameValue>();

        for (int i = 0; i < dtCountry.Rows.Count; i++)
        {
            string CountryId = dtCountry.Rows[i]["CNTR_Id"].ToString();
            string CountryName = dtCountry.Rows[i]["CNTR_Country"].ToString();
            cascadingValues.Add(new CascadingDropDownNameValue(CountryName, CountryId));
        }
        return cascadingValues.ToArray();
    }
    [WebMethod]

    [System.Web.Script.Services.ScriptMethod]

    public CascadingDropDownNameValue[] BindStateOnly(string knownCategoryValues, string category)
    {
        DataTable dt = new DataTable();
        dt = TMSState.GetSearch(null, null, null,1).Tables[0];

        List<CascadingDropDownNameValue> cascadingValues = new List<CascadingDropDownNameValue>();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string State_Id = dt.Rows[i]["ST_Id"].ToString();
            string State_Name = dt.Rows[i]["ST_State"].ToString();
            cascadingValues.Add(new CascadingDropDownNameValue(State_Name, State_Id));
        }
        return cascadingValues.ToArray();
    }


    [WebMethod]

    [System.Web.Script.Services.ScriptMethod]

    public CascadingDropDownNameValue[] BindState(string knownCategoryValues, string category)
    {
        string[] str = knownCategoryValues.Split(':');
        int CountryId = Convert.ToInt32(str[1].Substring(0, str[1].IndexOf(';')));

        DataTable dtState = new DataTable();
        dtState = TMSState.GetSearch(null, CountryId, null, 1).Tables[0];

        List<CascadingDropDownNameValue> cascadingValues = new List<CascadingDropDownNameValue>();

        for (int i = 0; i < dtState.Rows.Count; i++)
        {
            string StateId = dtState.Rows[i]["ST_Id"].ToString();
            string StateName = dtState.Rows[i]["ST_State"].ToString();
            cascadingValues.Add(new CascadingDropDownNameValue(StateName, StateId));
        }
        return cascadingValues.ToArray();
    }


    [WebMethod]

    [System.Web.Script.Services.ScriptMethod]

    public CascadingDropDownNameValue[] BindCity(string knownCategoryValues, string category)
    {
        string[] str = knownCategoryValues.Split(':');
        int StateId = Convert.ToInt32(str[2].Substring(0, str[2].IndexOf(';')));

        DataTable dtCity = new DataTable();
        dtCity = TMSCity.GetSearch(null, StateId, null, 1).Tables[0];

        List<CascadingDropDownNameValue> cascadingValues = new List<CascadingDropDownNameValue>();

        for (int i = 0; i < dtCity.Rows.Count; i++)
        {
            string CityId = dtCity.Rows[i]["CT_Id"].ToString();
            string CityName = dtCity.Rows[i]["CT_City"].ToString();
            cascadingValues.Add(new CascadingDropDownNameValue(CityName, CityId));
        }

        return cascadingValues.ToArray();
    }
    [WebMethod]

    [System.Web.Script.Services.ScriptMethod]

    public CascadingDropDownNameValue[] BindSubject(string knownCategoryValues, string category)
    {
       // string[] str = knownCategoryValues.Split(':');
        //int StateId = Convert.ToInt32(str[2].Substring(0, str[2].IndexOf(';')));

        DataTable dtSubject = new DataTable();
        dtSubject = TMSSubjectDetails.GetSearch(null, null, null, 1).Tables[0];

        List<CascadingDropDownNameValue> cascadingValues = new List<CascadingDropDownNameValue>();

        for (int i = 0; i < dtSubject.Rows.Count; i++)
        {
            string SubjectId = dtSubject.Rows[i]["SD_SubjectId"].ToString();
            string SubjectName = dtSubject.Rows[i]["SD_SubjectName"].ToString();
            cascadingValues.Add(new CascadingDropDownNameValue(SubjectName, SubjectId));
        }

        return cascadingValues.ToArray();
    }
    [WebMethod]

    [System.Web.Script.Services.ScriptMethod]
    public CascadingDropDownNameValue[] BindSchoolType(string knownCategoryValues, string category)
    {
        ///string[] str = knownCategoryValues.Split(':');
     //   int StateId = Convert.ToInt32(str[2].Substring(0, str[2].IndexOf(';')));

        DataTable dtSchoolType = new DataTable();
        dtSchoolType = TMSSchoolType.GetSearch(null, null, 1).Tables[0];

        List<CascadingDropDownNameValue> cascadingValues = new List<CascadingDropDownNameValue>();

        for (int i = 0; i < dtSchoolType.Rows.Count; i++)
        {
            string SchoolId = dtSchoolType.Rows[i]["ST_ST_TypeName"].ToString();
            string SchoolType = dtSchoolType.Rows[i]["ST_ST_TypeName"].ToString();
            cascadingValues.Add(new CascadingDropDownNameValue(SchoolType, SchoolId));
        }

        return cascadingValues.ToArray();
    }
    [WebMethod]

    [System.Web.Script.Services.ScriptMethod]
    public CascadingDropDownNameValue[] BindStandard(string knownCategoryValues, string category)
    {        
        string[] str = knownCategoryValues.Split(':');
        string SchoolType = str[1].Substring(0, str[1].IndexOf(';')).ToString();

        DataTable dtClass = new DataTable();
        dtClass = TMSSchoolCategory.GetSearch(null, null,SchoolType.ToString(),null, 1).Tables[0];

        List<CascadingDropDownNameValue> cascadingValues = new List<CascadingDropDownNameValue>();

        for (int i = 0; i < dtClass.Rows.Count; i++)
        {
            string ClassId = dtClass.Rows[i]["SC_CategoryId"].ToString();
            string ClassName = dtClass.Rows[i]["SC_CategoryName"].ToString();
            cascadingValues.Add(new CascadingDropDownNameValue(ClassName, ClassId));
        }

        return cascadingValues.ToArray();
    }
    [WebMethod]

    [System.Web.Script.Services.ScriptMethod]
    public CascadingDropDownNameValue[] BindDivision(string knownCategoryValues, string category)
    {
        string[] str = knownCategoryValues.Split(':');
        int SchoolID =Convert.ToInt32(str[2].Substring(0, str[2].IndexOf(';')));

        DataTable dtClass = new DataTable();
        dtClass = TMSSchoolSubCategory.GetSearch(null, SchoolID, null, null, 1).Tables[0];

        List<CascadingDropDownNameValue> cascadingValues = new List<CascadingDropDownNameValue>();

        for (int i = 0; i < dtClass.Rows.Count; i++)
        {
            string ClassId = dtClass.Rows[i]["SSC_SubCategoryId"].ToString();
            string ClassName = dtClass.Rows[i]["SSC_SubCategoryName"].ToString();
            cascadingValues.Add(new CascadingDropDownNameValue(ClassName, ClassId));
        }

        return cascadingValues.ToArray();
    }
}

