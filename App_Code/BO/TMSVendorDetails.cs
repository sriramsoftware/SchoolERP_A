using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSVendorDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? vdVendorId, System.Int64? vdVendorManagerId, System.String vdVendorDetailsId, System.String vdVendorName, System.String vdReleaventShop, System.String vdContactNo, System.String vdAlternateNumber, System.Int64? vdAddressId, System.String vdShopImage, System.String vdShopMap, System.String vdVendorImage, System.String vdVendorForPrePrimary, System.String vdVendorForPrimary, System.String vdVendorForHighSchool, System.String vdVendorForHouseUniform, System.String vdVendorSchoolUniform, System.String vdVendorSchoolShoes, System.String vdVendorSchoolBooks, System.String vdVendorSchoolBags, System.String vdVendorForBoys, System.String vdVendorForGirls, System.DateTime? vdDate, System.String vdWebsite, System.Int32? vdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSVendorDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, vdVendorId, vdVendorManagerId, vdVendorDetailsId, vdVendorName, vdReleaventShop, vdContactNo, vdAlternateNumber, vdAddressId, vdShopImage, vdShopMap, vdVendorImage, vdVendorForPrePrimary, vdVendorForPrimary, vdVendorForHighSchool, vdVendorForHouseUniform, vdVendorSchoolUniform, vdVendorSchoolShoes, vdVendorSchoolBooks, vdVendorSchoolBags, vdVendorForBoys, vdVendorForGirls, vdDate, vdWebsite, vdStatus);

        return db.ExecuteDataSet(dbCommand);
        
    }


    public static DataSet GetSearch(TMSVendorDetails searchObject)
    {
        return GetSearch(searchObject.VDVendorId, searchObject.VDVendorManagerId, searchObject.VDVendorDetailsId, searchObject.VDVendorName, searchObject.VDReleaventShop, searchObject.VDContactNo, searchObject.VDAlternateNumber, searchObject.VDAddressId, searchObject.VDShopImage, searchObject.VDShopMap, searchObject.VDVendorImage, searchObject.VDVendorForPrePrimary, searchObject.VDVendorForPrimary, searchObject.VDVendorForHighSchool, searchObject.VDVendorForHouseUniform, searchObject.VDVendorSchoolUniform, searchObject.VDVendorSchoolShoes, searchObject.VDVendorSchoolBooks, searchObject.VDVendorSchoolBags, searchObject.VDVendorForBoys, searchObject.VDVendorForGirls, searchObject.VDDate, searchObject.VDWebsite, searchObject.VDStatus);
    }

    /// <summary>
    /// Returns all TMSVendorDetails objects.
    /// </summary>
    /// <returns>List of all TMSVendorDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion


    public static DataSet BindAllVendorsandShopDetails(System.Int64? ManagerId, System.String PrePrimary, System.String Primary, System.String HighSchool, System.String HouseUniform, System.String SchoolUniform, System.String SchoolShoes, System.String SchoolBooks, System.String SchoolBags, System.String Boys, System.String Girls)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_GetAllVendorsandShopDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ManagerId, PrePrimary, Primary, HighSchool, HouseUniform, SchoolUniform, SchoolShoes, SchoolBooks, SchoolBags, Boys, Girls);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

}

