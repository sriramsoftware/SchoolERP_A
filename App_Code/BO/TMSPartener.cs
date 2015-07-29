using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSPartener
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? ptPartners, System.String ptTitle, System.String ptFirstName, System.String ptLastName, System.String ptEmailID, System.String ptMobileNo, System.String ptCorporateUrl, System.String ptJobTitle, System.String ptCountryName, System.String ptDescription, System.String ptDescription1, System.DateTime? ptDate, System.Int32? ptStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSPartener_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ptPartners, ptTitle, ptFirstName, ptLastName, ptEmailID, ptMobileNo, ptCorporateUrl, ptJobTitle, ptCountryName, ptDescription, ptDescription1, ptDate, ptStatus);

        ds = db.ExecuteDataSet(dbCommand);
       
        return ds;
    }


    public static DataSet GetSearch (TMSPartener searchObject)
    {
        return GetSearch(searchObject.PTPartners, searchObject.PTTitle, searchObject.PTFirstName, searchObject.PTLastName, searchObject.PTEmailID, searchObject.PTMobileNo, searchObject.PTCorporateUrl, searchObject.PTJobTitle, searchObject.PTCountryName, searchObject.PTDescription, searchObject.PTDescription1, searchObject.PTDate, searchObject.PTStatus);
    }

    /// <summary>
    /// Returns all TMSPartener objects.
    /// </summary>
    /// <returns>List of all TMSPartener objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null);
    }





    public static DataSet getPartnersDetails(System.Int64? ptPartners)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrgetPartnersDetails";  
        dbCommand = db.GetStoredProcCommand(sqlCommand, ptPartners);

        ds = db.ExecuteDataSet(dbCommand);
       
        return ds;
    }


    #endregion
}

