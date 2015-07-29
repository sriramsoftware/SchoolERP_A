using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSVendorItemOrderDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? viodDetailsId, System.Int64? viodVendorManagerId, System.Int64? viodVendorId, System.Int64? viodVendorItemId, System.Int32? viodQuantity, System.String viodPerItemCost, System.String viodTotalQuantityCost, System.String viodTotalCost, System.DateTime? viodDeliveredDate, System.String viodDeliveredStatus, System.String viodOrderRemark, System.DateTime? viodDate, System.Int32? viodStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSVendorItemOrderDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, viodDetailsId, viodVendorManagerId, viodVendorId, viodVendorItemId, viodQuantity, viodPerItemCost, viodTotalQuantityCost, viodTotalCost, viodDeliveredDate, viodDeliveredStatus, viodOrderRemark, viodDate, viodStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSVendorItemOrderDetails searchObject)
    {
        return GetSearch(searchObject.VIODDetailsId, searchObject.VIODVendorManagerId, searchObject.VIODVendorId, searchObject.VIODVendorItemId, searchObject.VIODQuantity, searchObject.VIODPerItemCost, searchObject.VIODTotalQuantityCost, searchObject.VIODTotalCost, searchObject.VIODDeliveredDate, searchObject.VIODDeliveredStatus, searchObject.VIODOrderRemark, searchObject.VIODDate, searchObject.VIODStatus);
    }

    /// <summary>
    /// Returns all TMSVendorItemOrderDetails objects.
    /// </summary>
    /// <returns>List of all TMSVendorItemOrderDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion



    public static DataSet GetAllItemsOrderDetailsVendorWise(System.Int64? ManagerLoginId, System.Int64? VendorId, System.String ItemType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[GetAllItemsOrderDetailsVendorWise]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ManagerLoginId, VendorId, ItemType);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }


    public static DataSet ItemsOrderDetails_AccoridngtoVendorandType(System.Int64? ManagerLoginId, System.Int64? VendorId, System.String ItemType, System.String SchoolType, System.String Gender)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[GetItemsOrderDetails_AccoridngtoVendorandType]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ManagerLoginId, VendorId, ItemType, SchoolType, Gender);
       // dbCommand = db.GetStoredProcCommand(sqlCommand, ManagerLoginId, VendorId, ItemType,SchoolType,Boys,Girls);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }


    public static DataSet BookDetails_AccoridngtoVendorandStandard(System.Int64? ManagerLoginId, System.Int64? VendorId, System.String ItemType, System.String SchoolType, System.String Standard)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[GetBookDetails_AccoridngtoVendorandSchoolType]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ManagerLoginId, VendorId, ItemType, SchoolType, Standard);
        // dbCommand = db.GetStoredProcCommand(sqlCommand, ManagerLoginId, VendorId, ItemType,SchoolType,Boys,Girls);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;

    }
}

