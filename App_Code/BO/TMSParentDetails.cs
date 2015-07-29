
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using TM.Connect;

public partial class TMSParentDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? pdParentId, System.Int64? pdStudentDetailsId, System.String pdParentRefId, System.Int64? pdFatherLoginId, System.Int64? pdMotherLoginId, System.String pdFatherFullName, System.String pdFatherPhoto, System.String pdFatherEduQualification, System.String pdFatherOccupation, System.Int64? pdFatherAddressId, System.String pdFatherOrgName, System.String pdFatherDsgtName, System.String pdMotherFullName, System.String pdMotherPhoto, System.String pdMotherEduQualification, System.String pdMotherOccupation, System.Int64? pdMotherAddressId, System.String pdMotherOrgName, System.String pdMotherDsgtName, System.DateTime? pdDate, System.Int32? pdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSParentDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, pdParentId, pdStudentDetailsId, pdParentRefId, pdFatherLoginId, pdMotherLoginId, pdFatherFullName, pdFatherPhoto, pdFatherEduQualification, pdFatherOccupation, pdFatherAddressId, pdFatherOrgName, pdFatherDsgtName, pdMotherFullName, pdMotherPhoto, pdMotherEduQualification, pdMotherOccupation, pdMotherAddressId, pdMotherOrgName, pdMotherDsgtName, pdDate, pdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSParentDetails searchObject)
    {
        return GetSearch(searchObject.PDParentId, searchObject.PDStudentDetailsId, searchObject.PDParentRefId, searchObject.PDFatherLoginId, searchObject.PDMotherLoginId, searchObject.PDFatherFullName, searchObject.PDFatherPhoto, searchObject.PDFatherEduQualification, searchObject.PDFatherOccupation, searchObject.PDFatherAddressId, searchObject.PDFatherOrgName, searchObject.PDFatherDsgtName, searchObject.PDMotherFullName, searchObject.PDMotherPhoto, searchObject.PDMotherEduQualification, searchObject.PDMotherOccupation, searchObject.PDMotherAddressId, searchObject.PDMotherOrgName, searchObject.PDMotherDsgtName, searchObject.PDDate, searchObject.PDStatus);
    }

    /// <summary>
    /// Returns all TMSParentDetails objects.
    /// </summary>
    /// <returns>List of all TMSParentDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
    SqlConnection Connection = null;

    public TMSParentDetails()
    {
        ConnectionManager conmgr = new ConnectionManager();
        Connection = conmgr.Getconnection();
    }

    public DataSet GetLoginParentDetails(int Log_Parent_Id)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("TMS_GetLoginParentDetails", Connection);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;

        da.SelectCommand.Parameters.AddWithValue("@Log_Parent_Id", Log_Parent_Id);
        da.Fill(ds, "LogIn_Parent_Data");
        return ds;
    }

    public DataSet GetLoginChildDetails(int StudentID, int Parent_Id)
    {
        System.Data.DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter("TMS_GetParentCurrentChildDetails", Connection);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;

        da.SelectCommand.Parameters.AddWithValue("@StudentID", StudentID);
        da.SelectCommand.Parameters.AddWithValue("@Parent_Id", Parent_Id);

        da.Fill(ds, "StudDetails");
        return ds;

    }

    public DataSet GetLoginChildDetailsById(int StudentID, int Parent_Id)
    {
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter("TMS_GetLoginParentDetailsForChild", Connection);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;

        da.SelectCommand.Parameters.AddWithValue("@StudentID", StudentID);
        da.SelectCommand.Parameters.AddWithValue("@Parent_Id", Parent_Id);

        da.Fill(ds, "StudDetails");
        return ds;
    }

    public DataSet GetParent_ClildDetails(int Parent_Id)
    {
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter("TMS_GetParentChildDetails", Connection);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;

        //da.SelectCommand.Parameters.AddWithValue("@StudentID", StudentID);
        da.SelectCommand.Parameters.AddWithValue("@Parent_Id", Parent_Id);

        da.Fill(ds, "ParentChild");
        return ds;
    }

    public DataSet GetParentIdByLoginId(int Log_Parent_Id)
    {
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter("TMS_GetParentIdByLoginId", Connection);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;

        //da.SelectCommand.Parameters.AddWithValue("@StudentID", StudentID);
        da.SelectCommand.Parameters.AddWithValue("@Log_Parent_Id", Log_Parent_Id);

        da.Fill(ds, "ParentId");
        return ds;
    }

    public DataSet GetChildDetailsForEdit(int Stud_Id, int Parent_Id)
    {
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter("TMS_GetParentChildDetailsForEdit", Connection);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;

        da.SelectCommand.Parameters.AddWithValue("@Stud_Id", Stud_Id);
        da.SelectCommand.Parameters.AddWithValue("@Parent_Id", Parent_Id);

        da.Fill(ds, "EditChildProfile");
        return ds;
    }

    public DataSet GetCountryDetails()
    {
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter("TMS_GetCountryDetails", Connection);
        da.Fill(ds, "Country");
        return ds;
    }

    public DataSet GetCityByCountry(int ddlCountryId)
    {
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter("TMS_GetStateListByCountryId", Connection);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;

        da.SelectCommand.Parameters.AddWithValue("@ddlCountryId", ddlCountryId);
        da.Fill(ds, "State");

        return ds;
    }

    public DataSet GetCityNamesByStateId(int ddlStateId)
    {
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter("TMS_GetCityListByStateId", Connection);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;

        da.SelectCommand.Parameters.AddWithValue("@ddlStateId", ddlStateId);
        da.Fill(ds, "City");

        return ds;
    }

    public DataSet GetEducationList()
    {
        DataSet ds = new DataSet();

        SqlDataAdapter da = new SqlDataAdapter("TMS_GetEducationListDetails", Connection);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;

        
        da.Fill(ds, "Education");

        return ds;
    }

    public bool UploadNewChildImage(int Stud_Id, string ImagePath)
    {
        bool IsUpdate = false;

        Connection.Open();
        SqlCommand cmd = new SqlCommand("TMS_UploadChildImage", Connection);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@Stud_Id", Stud_Id);
        cmd.Parameters.AddWithValue("@ImagePath", ImagePath);

        IsUpdate = Convert.ToBoolean(cmd.ExecuteNonQuery());
        Connection.Close();
        return IsUpdate;
    }

    public bool UpdateParentPhoto(int Log_Parent_Id, string ParentPhotoPath)
    {
        bool IsUpdate = false;

        Connection.Open();
        SqlCommand cmd = new SqlCommand("TMS_UploadParentImage", Connection);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@Log_Parent_Id", Log_Parent_Id);
        cmd.Parameters.AddWithValue("@ParentPhotoPath", ParentPhotoPath);

        IsUpdate = Convert.ToBoolean(cmd.ExecuteNonQuery());
        Connection.Close();
        return IsUpdate;
    }


    public static DataSet GetNames(System.Int64? senderId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_GetFatherandMontherName]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, senderId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
}

