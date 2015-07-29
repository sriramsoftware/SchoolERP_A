using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSCertificateDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? certificateId, System.String certificateName, System.Int64? certificateForStudentId, System.Int64? certificateForStandardId, System.Int64? certificateForDivisionId, System.DateTime? certificateRequestDate, System.String certificateRequestedBy, System.Int64? certificateRequestedId, System.String certificateReason, System.Int64? certificateNextApplicationId, System.Int64? certificatePrincipalLoginId, System.Int64? certificateAccountManagerLoginId, System.Int64? certificateStockManagerLoginId, System.Int64? certificateLibraryManagerLoginId, System.String certificatePrincipalApprovedStatus, System.String certificateStockApprovedStatus, System.String certificateLibraryApprovedStatus, System.String certificateAccountApproveSatus, System.DateTime? certificatePrincipalApproveDate, System.DateTime? certificateStockApproveDate, System.DateTime? certificateLibraryApproveDate, System.DateTime? certificateAccountApprovedDate, System.Boolean? certificateStatus, System.Int64? certificateNotificationStatus, System.String certificationApprovedBy, System.DateTime? certificationExtra1, System.String certificateExtra2, System.Int64? certificateExtra3, System.Boolean? certificateExtra4)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSCertificateDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, certificateId, certificateName, certificateForStudentId, certificateForStandardId, certificateForDivisionId, certificateRequestDate, certificateRequestedBy, certificateRequestedId, certificateReason, certificateNextApplicationId, certificatePrincipalLoginId, certificateAccountManagerLoginId, certificateStockManagerLoginId, certificateLibraryManagerLoginId, certificatePrincipalApprovedStatus, certificateStockApprovedStatus, certificateLibraryApprovedStatus, certificateAccountApproveSatus, certificatePrincipalApproveDate, certificateStockApproveDate, certificateLibraryApproveDate, certificateAccountApprovedDate, certificateStatus, certificateNotificationStatus, certificationApprovedBy, certificationExtra1, certificateExtra2, certificateExtra3, certificateExtra4);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSCertificateDetails searchObject)
    {
        return GetSearch(searchObject.CertificateId, searchObject.CertificateName, searchObject.CertificateForStudentId, searchObject.CertificateForStandardId, searchObject.CertificateForDivisionId, searchObject.CertificateRequestDate, searchObject.CertificateRequestedBy, searchObject.CertificateRequestedId, searchObject.CertificateReason, searchObject.CertificateNextApplicationId, searchObject.CertificatePrincipalLoginId, searchObject.CertificateAccountManagerLoginId, searchObject.CertificateStockManagerLoginId, searchObject.CertificateLibraryManagerLoginId, searchObject.CertificatePrincipalApprovedStatus, searchObject.CertificateStockApprovedStatus, searchObject.CertificateLibraryApprovedStatus, searchObject.CertificateAccountApproveSatus, searchObject.CertificatePrincipalApproveDate, searchObject.CertificateStockApproveDate, searchObject.CertificateLibraryApproveDate, searchObject.CertificateAccountApprovedDate, searchObject.CertificateStatus, searchObject.CertificateNotificationStatus, searchObject.CertificationApprovedBy, searchObject.CertificationExtra1, searchObject.CertificateExtra2, searchObject.CertificateExtra3, searchObject.CertificateExtra4);
    }

    /// <summary>
    /// Returns all TMSCertificateDetails objects.
    /// </summary>
    /// <returns>List of all TMSCertificateDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion


    public static DataSet GetCertificateCount()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspGetReceived_Certificate_ApplicationCount";
        dbCommand = db.GetStoredProcCommand(sqlCommand);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetStudent_CertificateDetails(System.Int64? certificateId, System.String certificateName, System.Int64? certificateForStudentId, System.Int64? certificateForStandardId, System.Int64? certificateForDivisionId, System.DateTime? certificateRequestDate, System.String certificateRequestedBy, System.Int64? certificateRequestedId, System.Int64? certificatePrincipalLoginId, System.Int64? certificateAccountManagerLoginId, System.Int64? certificateStockManagerLoginId, System.Int64? certificateLibraryManagerLoginId, System.String certificatePrincipalApprovedStatus, System.String certificateStockApprovedStatus, System.String certificateLibraryApprovedStatus, System.String certificateAccountApproveSatus, System.Boolean? certificateStatus, System.Int64? certificateNotificationStatus, System.String certificationApprovedBy)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMS_Student_CertificateDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, certificateId, certificateName, certificateForStudentId, certificateForStandardId, certificateForDivisionId, certificateRequestDate, certificateRequestedBy, certificateRequestedId, certificatePrincipalLoginId, certificateAccountManagerLoginId, certificateStockManagerLoginId, certificateLibraryManagerLoginId, certificatePrincipalApprovedStatus, certificateStockApprovedStatus, certificateLibraryApprovedStatus, certificateAccountApproveSatus, certificateStatus, certificateNotificationStatus, certificationApprovedBy);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    //Get Certificate Number
    public static DataSet GetTCCertificateNumber(System.Int64? certificateId, System.String certificateName, System.Int64? certificateForStudentId,System.String certificatePrincipalApprovedStatus,System.String certificateExtra2)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSCertificateDetails_GetTCNumber";
        dbCommand = db.GetStoredProcCommand(sqlCommand, certificateId, certificateName, certificateForStudentId,certificatePrincipalApprovedStatus,certificateExtra2);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
}

