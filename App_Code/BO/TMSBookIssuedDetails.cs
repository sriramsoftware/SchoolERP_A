using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSBookIssuedDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? bidBookId, System.Int64? bidLibraryManagerId, System.Int64? bidUserLoginId, System.Int64? bidSubjectId, System.Int64? bidStandardId, System.Int64? bidDivisionId, System.Int64? bidBookDetailsId, System.DateTime? bidBookIssuedDate, System.DateTime? bidBookSubmitDate, System.Double? bidBookLateFees, System.Double? bidBookDeposite, System.Double? bidBookOhterCharges, System.String bidBookSubmittedStatus, System.String bidBookExtraColumn1, System.String bidBookExtraColumn2, System.String bidBookExtraColumn3, System.String bidBookExtraColumn4, System.Double? bidBookExtraFees1, System.Double? bidBookExtraFees2, System.DateTime? bidBookExtraDate1, System.DateTime? bidBookExtraDate2, System.Boolean? bidStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSBookIssuedDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, bidBookId, bidLibraryManagerId, bidUserLoginId, bidSubjectId, bidStandardId, bidDivisionId, bidBookDetailsId, bidBookIssuedDate, bidBookSubmitDate, bidBookLateFees, bidBookDeposite, bidBookOhterCharges, bidBookSubmittedStatus, bidBookExtraColumn1, bidBookExtraColumn2, bidBookExtraColumn3, bidBookExtraColumn4, bidBookExtraFees1, bidBookExtraFees2, bidBookExtraDate1, bidBookExtraDate2, bidStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSBookIssuedDetails searchObject)
    {
        return GetSearch(searchObject.BIDBookId, searchObject.BIDLibraryManagerId, searchObject.BIDUserLoginId, searchObject.BIDSubjectId, searchObject.BIDStandardId, searchObject.BIDDivisionId, searchObject.BIDBookDetailsId, searchObject.BIDBookIssuedDate, searchObject.BIDBookSubmitDate, searchObject.BIDBookLateFees, searchObject.BIDBookDeposite, searchObject.BIDBookOhterCharges, searchObject.BIDBookSubmittedStatus, searchObject.BIDBookExtraColumn1, searchObject.BIDBookExtraColumn2, searchObject.BIDBookExtraColumn3, searchObject.BIDBookExtraColumn4, searchObject.BIDBookExtraFees1, searchObject.BIDBookExtraFees2, searchObject.BIDBookExtraDate1, searchObject.BIDBookExtraDate2, searchObject.BIDStatus);
    }

    /// <summary>
    /// Returns all TMSBookIssuedDetails objects.
    /// </summary>
    /// <returns>List of all TMSBookIssuedDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion


    public static DataSet BookIssuedDetails_ForStudent_OR_Teacher(System.Int64? bidBookId, System.Int64? bidLibraryManagerId, System.Int64? bidUserLoginId, System.Int64? bidSubjectId, System.Int64? bidStandardId, System.Int64? bidDivisionId, System.Int64? bidBookDetailsId, System.DateTime? bidBookIssuedDate, System.DateTime? bidBookSubmitDate,System.String bidBookSubmittedStatus, System.Boolean? bidStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSBookIssuedDetails_ForStudent_OR_Teacher";
        dbCommand = db.GetStoredProcCommand(sqlCommand, bidBookId, bidLibraryManagerId, bidUserLoginId, bidSubjectId, bidStandardId, bidDivisionId, bidBookDetailsId, bidBookIssuedDate, bidBookSubmitDate,  bidBookSubmittedStatus, bidStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
}

