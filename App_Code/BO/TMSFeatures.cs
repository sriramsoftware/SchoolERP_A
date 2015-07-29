
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;


public partial class TMSFeatures
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? feFeatureID, System.String feTitle, System.String feSubTitle, System.String feDescription, System.String feImage, System.String efType, System.String feImageLogo, System.DateTime? feDate, System.Int32? feStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSFeatures_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, feFeatureID, feTitle, feSubTitle, feDescription, feImage, efType, feImageLogo, feDate, feStatus);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetSearch(TMSFeatures searchObject)
    {
        return GetSearch(searchObject.FEFeatureID, searchObject.FETitle, searchObject.FESubTitle, searchObject.FEDescription, searchObject.FEImage, searchObject.EFType, searchObject.FEImageLogo, searchObject.FEDate, searchObject.FEStatus);
    }

    /// <summary>
    /// Returns all TMSFeatures objects.
    /// </summary>
    /// <returns>List of all TMSFeatures objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null);
    }



    public static DataSet GetFeaturedDetails(System.Int64? feFeatureID, System.String efType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetFetureDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, feFeatureID, efType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetTop6FeaturedDetails(System.Int64? feFeatureID, System.String efType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspTMSrGettopFetureDetails]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, feFeatureID, efType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }



    public static DataSet GetFetureMenuListDetails(System.Int64? feFeatureID, System.String efType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetFetureMenuListDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, feFeatureID, efType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    #endregion
}

