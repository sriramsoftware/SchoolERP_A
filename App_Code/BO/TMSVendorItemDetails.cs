using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSVendorItemDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? vidDetailsId, System.Int64? vidVendorId, System.String vidItemType, System.String vidSchoolType, System.String vidSchoolSubType, System.String vidBoys, System.String vidGirls, System.String vidItemName, System.String vidBookName, System.String vidItemColor, System.String vidItemBookAuthor, System.String vidItemBookPublication, System.String vidItemSize, System.String vidItemCost, System.String vidItemStatus, System.DateTime? vidDate, System.Int32? vidStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSVendorItemDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, vidDetailsId, vidVendorId, vidItemType, vidSchoolType, vidSchoolSubType, vidBoys, vidGirls, vidItemName, vidBookName, vidItemColor, vidItemBookAuthor, vidItemBookPublication, vidItemSize, vidItemCost, vidItemStatus, vidDate, vidStatus);

        return db.ExecuteDataSet(dbCommand);

    }


    public static DataSet GetSearch(TMSVendorItemDetails searchObject)
    {
        return GetSearch(searchObject.VIDDetailsId, searchObject.VIDVendorId, searchObject.VIDItemType, searchObject.VIDSchoolType, searchObject.VIDSchoolSubType, searchObject.VIDBoys, searchObject.VIDGirls, searchObject.VIDItemName, searchObject.VIDBookName, searchObject.VIDItemColor, searchObject.VIDItemBookAuthor, searchObject.VIDItemBookPublication, searchObject.VIDItemSize, searchObject.VIDItemCost, searchObject.VIDItemStatus, searchObject.VIDDate, searchObject.VIDStatus);
    }

    /// <summary>
    /// Returns all TMSVendorItemDetails objects.
    /// </summary>
    /// <returns>List of all TMSVendorItemDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion


    public static DataSet GetBookDetails()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSVendorBookDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }

    public static DataSet GetSchoolItemDetails()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSVendorSchoolItemDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }

    public static DataSet GetSchoolUniformDetails_ForAll(System.Int64? VendorId, System.String ItemType, System.String SchoolType, System.String UniformType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_GetSchoolUniformDetailsForAll]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, VendorId, ItemType, SchoolType, UniformType);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    public static DataSet GetSchoolUniformDetails_ForAllWithStatus(System.Int64? VendorId, System.String ItemType, System.String SchoolType, System.String UniformType,String AvailableStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_GetSchoolUniformDetailsForAllwithstatus]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, VendorId, ItemType, SchoolType, UniformType, AvailableStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
    public static DataSet GetSchoolUniformDetails_ForBoys(System.Int64? VendorId, System.String ItemType, System.String SchoolType, System.String Boys)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_GetSchoolUniformDetailsForBoys";
        dbCommand = db.GetStoredProcCommand(sqlCommand, VendorId, ItemType, SchoolType, Boys);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }


    public static DataSet GetSchoolUniformDetails_ForGirls(System.Int64? VendorId, System.String ItemType, System.String SchoolType, System.String Girls)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_GetSchoolUniformDetailsForGirls";
        dbCommand = db.GetStoredProcCommand(sqlCommand, VendorId, ItemType, SchoolType, Girls);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }


    public static DataSet GetSchoolShoesDetails_ForBoys(System.Int64? VendorId, System.String ItemType, System.String Boys, System.String ItemName)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_GetSchoolShoesDetailsForBoys";
        dbCommand = db.GetStoredProcCommand(sqlCommand, VendorId, ItemType, Boys, ItemName);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }


    public static DataSet GetSchoolShoesDetails_ForGirls(System.Int64? VendorId, System.String ItemType, System.String Girls, System.String ItemName)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_GetSchoolShoesDetailsForGirls";
        dbCommand = db.GetStoredProcCommand(sqlCommand, VendorId, ItemType, Girls, ItemName);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetCanvasShoesDetailsForBoth(System.Int64? VendorId, System.String ItemType, System.String ItemName)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_GetCanvasShoesDetailsForBoth";
        dbCommand = db.GetStoredProcCommand(sqlCommand, VendorId, ItemType, ItemName);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetSchoolBookDetails(System.Int64? VendorId, System.String ItemType, System.String SchoolType, System.String SubSchoolType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_GetSchoolBookDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, VendorId, ItemType, SchoolType, SubSchoolType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetSchoolBookDetailsWithStatus(System.Int64? VendorId, System.String ItemType, System.String SchoolType, System.String SubSchoolType,String AvailableStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_GetSchoolBookDetailsWithStatus]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, VendorId, ItemType, SchoolType, SubSchoolType,AvailableStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetSchoolBagsDetails(System.Int64? VendorId, System.String ItemType, System.String SchoolType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_GetSchoolBagsDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, VendorId, ItemType, SchoolType);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetSchoolBagsDetailsWithStatus(System.Int64? VendorId, System.String ItemType, System.String SchoolType, String AvailableStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[TMS_GetSchoolBagsDetailsWithStatus]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, VendorId, ItemType, SchoolType, AvailableStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
}

