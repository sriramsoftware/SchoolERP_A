using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSSEOManagement
{
    #region GetSEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? seoId, System.String seoPageName, System.String seoTitle, System.String seoKeywords, System.String seoDescription, System.String seoMetaType, System.DateTime? seoDate, System.String seoAddedyBy, System.Int64? seoAddedById, System.Int32? seoStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;

        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSSEOManagement_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, seoId, seoPageName, seoTitle, seoKeywords, seoDescription, seoMetaType, seoDate, seoAddedyBy, seoAddedById, seoStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSSEOManagement searchObject)
    {
        return GetSearch(searchObject.SEOId, searchObject.SEOPageName, searchObject.SEOTitle, searchObject.SEOKeywords, searchObject.SEODescription, searchObject.SEOMetaType, searchObject.SEODate, searchObject.SEOAddedyBy, searchObject.SEOAddedById, searchObject.SEOStatus);
    }

    /// <summary>
    /// Returns all TMSSEOManagement objects.
    /// </summary>
    /// <returns>List of all TMSSEOManagement objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

