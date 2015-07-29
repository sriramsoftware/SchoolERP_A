

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;


public partial class TMSAddressDetails
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? adAddressId, System.String adPermanentAddress, System.String adOfficeAddress, System.String adCommercialAddress, System.String adOptionalAddress, System.String adLandLineNo, System.String adOfficeNo, System.String adMobileNo, System.String adMobileOptionalNo, System.String adEmailId, System.String adPinCode, System.String adZipCode, System.Int64? adCountryId, System.Int64? adStateId, System.Int64? adCityId, System.DateTime? adAddressDate, System.Int32? adStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSAddressDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adAddressId, adPermanentAddress, adOfficeAddress, adCommercialAddress, adOptionalAddress, adLandLineNo, adOfficeNo, adMobileNo, adMobileOptionalNo, adEmailId, adPinCode, adZipCode, adCountryId, adStateId, adCityId, adAddressDate, adStatus);

        ds = db.ExecuteDataSet(dbCommand);
       
        return (ds);
    }


    public static DataSet GetSearch(TMSAddressDetails searchObject)
    {
        return GetSearch(searchObject.ADAddressId, searchObject.ADPermanentAddress, searchObject.ADOfficeAddress, searchObject.ADCommercialAddress, searchObject.ADOptionalAddress, searchObject.ADLandLineNo, searchObject.ADOfficeNo, searchObject.ADMobileNo, searchObject.ADMobileOptionalNo, searchObject.ADEmailId, searchObject.ADPinCode, searchObject.ADZipCode, searchObject.ADCountryId, searchObject.ADStateId, searchObject.ADCityId, searchObject.ADAddressDate, searchObject.ADStatus);
    }

    /// <summary>
    /// Returns all TMSAddressDetails objects.
    /// </summary>
    /// <returns>List of all TMSAddressDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion




    public static DataSet alreayexistAddressDetails(System.Int64? adAddressId, System.String adPermanentAddress, System.String adOfficeAddress, System.String adCommercialAddress, System.String adOptionalAddress, System.String adLandLineNo, System.String adOfficeNo, System.String adMobileNo, System.String adMobileOptionalNo, System.String adEmailId, System.String adPinCode, System.String adZipCode, System.Int64? adCountryId, System.Int64? adStateId, System.Int64? adCityId, System.DateTime? adAddressDate, System.Int32? adStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
           

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSalreayexistAddressDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, adAddressId, adPermanentAddress, adOfficeAddress, adCommercialAddress, adOptionalAddress, adLandLineNo, adOfficeNo, adMobileNo, adMobileOptionalNo, adEmailId, adPinCode, adZipCode, adCountryId, adStateId, adCityId, adAddressDate, adStatus);

        ds = db.ExecuteDataSet(dbCommand);
       
        return (ds);
    }

}

