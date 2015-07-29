/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/2/2013 12:44:06 PM                                    */
/*                                                                          */
/* www.CodeAuthor.org                                                       */
/****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

[DataObject]
[Serializable]
public partial class TMSCertificateDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_CertificateDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _certificateId;
	private System.String _certificateName;
	private System.Int64? _certificateForStudentId;
	private System.Int64? _certificateForStandardId;
	private System.Int64? _certificateForDivisionId;
	private System.DateTime? _certificateRequestDate;
	private System.String _certificateRequestedBy;
	private System.Int64? _certificateRequestedId;
	private System.String _certificateReason;
	private System.Int64? _certificateNextApplicationId;
	private System.Int64? _certificatePrincipalLoginId;
	private System.Int64? _certificateAccountManagerLoginId;
	private System.Int64? _certificateStockManagerLoginId;
	private System.Int64? _certificateLibraryManagerLoginId;
	private System.String _certificatePrincipalApprovedStatus;
	private System.String _certificateStockApprovedStatus;
	private System.String _certificateLibraryApprovedStatus;
	private System.String _certificateAccountApproveSatus;
	private System.DateTime? _certificatePrincipalApproveDate;
	private System.DateTime? _certificateStockApproveDate;
	private System.DateTime? _certificateLibraryApproveDate;
	private System.DateTime? _certificateAccountApprovedDate;
	private System.Boolean? _certificateStatus;
	private System.Int64? _certificateNotificationStatus;
	private System.String _certificationApprovedBy;
	private System.DateTime? _certificationExtra1;
	private System.String _certificateExtra2;
	private System.Int64? _certificateExtra3;
	private System.Boolean? _certificateExtra4;
	
	#endregion
	
	
	#region Properties
	public System.Int64? CertificateId
	{
		get
		{
			return _certificateId;
		}
		set
		{
			_certificateId = value;
		}
	}
	
	public System.String CertificateName
	{
		get
		{
			return _certificateName;
		}
		set
		{
			_certificateName = value;
		}
	}
	
	public System.Int64? CertificateForStudentId
	{
		get
		{
			return _certificateForStudentId;
		}
		set
		{
			_certificateForStudentId = value;
		}
	}
	
	public System.Int64? CertificateForStandardId
	{
		get
		{
			return _certificateForStandardId;
		}
		set
		{
			_certificateForStandardId = value;
		}
	}
	
	public System.Int64? CertificateForDivisionId
	{
		get
		{
			return _certificateForDivisionId;
		}
		set
		{
			_certificateForDivisionId = value;
		}
	}
	
	public System.DateTime? CertificateRequestDate
	{
		get
		{
			return _certificateRequestDate;
		}
		set
		{
			_certificateRequestDate = value;
		}
	}
	
	public System.String CertificateRequestedBy
	{
		get
		{
			return _certificateRequestedBy;
		}
		set
		{
			_certificateRequestedBy = value;
		}
	}
	
	public System.Int64? CertificateRequestedId
	{
		get
		{
			return _certificateRequestedId;
		}
		set
		{
			_certificateRequestedId = value;
		}
	}
	
	public System.String CertificateReason
	{
		get
		{
			return _certificateReason;
		}
		set
		{
			_certificateReason = value;
		}
	}
	
	public System.Int64? CertificateNextApplicationId
	{
		get
		{
			return _certificateNextApplicationId;
		}
		set
		{
			_certificateNextApplicationId = value;
		}
	}
	
	public System.Int64? CertificatePrincipalLoginId
	{
		get
		{
			return _certificatePrincipalLoginId;
		}
		set
		{
			_certificatePrincipalLoginId = value;
		}
	}
	
	public System.Int64? CertificateAccountManagerLoginId
	{
		get
		{
			return _certificateAccountManagerLoginId;
		}
		set
		{
			_certificateAccountManagerLoginId = value;
		}
	}
	
	public System.Int64? CertificateStockManagerLoginId
	{
		get
		{
			return _certificateStockManagerLoginId;
		}
		set
		{
			_certificateStockManagerLoginId = value;
		}
	}
	
	public System.Int64? CertificateLibraryManagerLoginId
	{
		get
		{
			return _certificateLibraryManagerLoginId;
		}
		set
		{
			_certificateLibraryManagerLoginId = value;
		}
	}
	
	public System.String CertificatePrincipalApprovedStatus
	{
		get
		{
			return _certificatePrincipalApprovedStatus;
		}
		set
		{
			_certificatePrincipalApprovedStatus = value;
		}
	}
	
	public System.String CertificateStockApprovedStatus
	{
		get
		{
			return _certificateStockApprovedStatus;
		}
		set
		{
			_certificateStockApprovedStatus = value;
		}
	}
	
	public System.String CertificateLibraryApprovedStatus
	{
		get
		{
			return _certificateLibraryApprovedStatus;
		}
		set
		{
			_certificateLibraryApprovedStatus = value;
		}
	}
	
	public System.String CertificateAccountApproveSatus
	{
		get
		{
			return _certificateAccountApproveSatus;
		}
		set
		{
			_certificateAccountApproveSatus = value;
		}
	}
	
	public System.DateTime? CertificatePrincipalApproveDate
	{
		get
		{
			return _certificatePrincipalApproveDate;
		}
		set
		{
			_certificatePrincipalApproveDate = value;
		}
	}
	
	public System.DateTime? CertificateStockApproveDate
	{
		get
		{
			return _certificateStockApproveDate;
		}
		set
		{
			_certificateStockApproveDate = value;
		}
	}
	
	public System.DateTime? CertificateLibraryApproveDate
	{
		get
		{
			return _certificateLibraryApproveDate;
		}
		set
		{
			_certificateLibraryApproveDate = value;
		}
	}
	
	public System.DateTime? CertificateAccountApprovedDate
	{
		get
		{
			return _certificateAccountApprovedDate;
		}
		set
		{
			_certificateAccountApprovedDate = value;
		}
	}
	
	public System.Boolean? CertificateStatus
	{
		get
		{
			return _certificateStatus;
		}
		set
		{
			_certificateStatus = value;
		}
	}
	
	public System.Int64? CertificateNotificationStatus
	{
		get
		{
			return _certificateNotificationStatus;
		}
		set
		{
			_certificateNotificationStatus = value;
		}
	}
	
	public System.String CertificationApprovedBy
	{
		get
		{
			return _certificationApprovedBy;
		}
		set
		{
			_certificationApprovedBy = value;
		}
	}
	
	public System.DateTime? CertificationExtra1
	{
		get
		{
			return _certificationExtra1;
		}
		set
		{
			_certificationExtra1 = value;
		}
	}
	
	public System.String CertificateExtra2
	{
		get
		{
			return _certificateExtra2;
		}
		set
		{
			_certificateExtra2 = value;
		}
	}
	
	public System.Int64? CertificateExtra3
	{
		get
		{
			return _certificateExtra3;
		}
		set
		{
			_certificateExtra3 = value;
		}
	}
	
	public System.Boolean? CertificateExtra4
	{
		get
		{
			return _certificateExtra4;
		}
		set
		{
			_certificateExtra4 = value;
		}
	}
	
	#endregion
	
	
	#region Methods
	
	
	#region Mapping Methods
	
	protected void MapTo(DataSet ds)
	{
		DataRow dr;
		
		
		if (ds == null)
		ds = new DataSet();
		
		if (ds.Tables["TABLE_NAME"] == null)
		ds.Tables.Add(TABLE_NAME);
		
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_Id", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_Name", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_ForStudentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_ForStandardId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_ForDivisionId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_RequestDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_RequestedBy", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_RequestedId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_Reason", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_NextApplicationId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_PrincipalLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_AccountManagerLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_StockManagerLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_LibraryManagerLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_PrincipalApprovedStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_StockApprovedStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_LibraryApprovedStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_AccountApproveSatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_PrincipalApproveDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_StockApproveDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_LibraryApproveDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_AccountApprovedDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_Status", typeof(System.Boolean) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_NotificationStatus", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("Certification_ApprovedBy", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Certification_Extra1", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_Extra2", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_Extra3", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("Certificate_Extra4", typeof(System.Boolean) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (CertificateId == null)
		dr["Certificate_Id"] = DBNull.Value;
		else
		dr["Certificate_Id"] = CertificateId;
		
		if (CertificateName == null)
		dr["Certificate_Name"] = DBNull.Value;
		else
		dr["Certificate_Name"] = CertificateName;
		
		if (CertificateForStudentId == null)
		dr["Certificate_ForStudentId"] = DBNull.Value;
		else
		dr["Certificate_ForStudentId"] = CertificateForStudentId;
		
		if (CertificateForStandardId == null)
		dr["Certificate_ForStandardId"] = DBNull.Value;
		else
		dr["Certificate_ForStandardId"] = CertificateForStandardId;
		
		if (CertificateForDivisionId == null)
		dr["Certificate_ForDivisionId"] = DBNull.Value;
		else
		dr["Certificate_ForDivisionId"] = CertificateForDivisionId;
		
		if (CertificateRequestDate == null)
		dr["Certificate_RequestDate"] = DBNull.Value;
		else
		dr["Certificate_RequestDate"] = CertificateRequestDate;
		
		if (CertificateRequestedBy == null)
		dr["Certificate_RequestedBy"] = DBNull.Value;
		else
		dr["Certificate_RequestedBy"] = CertificateRequestedBy;
		
		if (CertificateRequestedId == null)
		dr["Certificate_RequestedId"] = DBNull.Value;
		else
		dr["Certificate_RequestedId"] = CertificateRequestedId;
		
		if (CertificateReason == null)
		dr["Certificate_Reason"] = DBNull.Value;
		else
		dr["Certificate_Reason"] = CertificateReason;
		
		if (CertificateNextApplicationId == null)
		dr["Certificate_NextApplicationId"] = DBNull.Value;
		else
		dr["Certificate_NextApplicationId"] = CertificateNextApplicationId;
		
		if (CertificatePrincipalLoginId == null)
		dr["Certificate_PrincipalLoginId"] = DBNull.Value;
		else
		dr["Certificate_PrincipalLoginId"] = CertificatePrincipalLoginId;
		
		if (CertificateAccountManagerLoginId == null)
		dr["Certificate_AccountManagerLoginId"] = DBNull.Value;
		else
		dr["Certificate_AccountManagerLoginId"] = CertificateAccountManagerLoginId;
		
		if (CertificateStockManagerLoginId == null)
		dr["Certificate_StockManagerLoginId"] = DBNull.Value;
		else
		dr["Certificate_StockManagerLoginId"] = CertificateStockManagerLoginId;
		
		if (CertificateLibraryManagerLoginId == null)
		dr["Certificate_LibraryManagerLoginId"] = DBNull.Value;
		else
		dr["Certificate_LibraryManagerLoginId"] = CertificateLibraryManagerLoginId;
		
		if (CertificatePrincipalApprovedStatus == null)
		dr["Certificate_PrincipalApprovedStatus"] = DBNull.Value;
		else
		dr["Certificate_PrincipalApprovedStatus"] = CertificatePrincipalApprovedStatus;
		
		if (CertificateStockApprovedStatus == null)
		dr["Certificate_StockApprovedStatus"] = DBNull.Value;
		else
		dr["Certificate_StockApprovedStatus"] = CertificateStockApprovedStatus;
		
		if (CertificateLibraryApprovedStatus == null)
		dr["Certificate_LibraryApprovedStatus"] = DBNull.Value;
		else
		dr["Certificate_LibraryApprovedStatus"] = CertificateLibraryApprovedStatus;
		
		if (CertificateAccountApproveSatus == null)
		dr["Certificate_AccountApproveSatus"] = DBNull.Value;
		else
		dr["Certificate_AccountApproveSatus"] = CertificateAccountApproveSatus;
		
		if (CertificatePrincipalApproveDate == null)
		dr["Certificate_PrincipalApproveDate"] = DBNull.Value;
		else
		dr["Certificate_PrincipalApproveDate"] = CertificatePrincipalApproveDate;
		
		if (CertificateStockApproveDate == null)
		dr["Certificate_StockApproveDate"] = DBNull.Value;
		else
		dr["Certificate_StockApproveDate"] = CertificateStockApproveDate;
		
		if (CertificateLibraryApproveDate == null)
		dr["Certificate_LibraryApproveDate"] = DBNull.Value;
		else
		dr["Certificate_LibraryApproveDate"] = CertificateLibraryApproveDate;
		
		if (CertificateAccountApprovedDate == null)
		dr["Certificate_AccountApprovedDate"] = DBNull.Value;
		else
		dr["Certificate_AccountApprovedDate"] = CertificateAccountApprovedDate;
		
		if (CertificateStatus == null)
		dr["Certificate_Status"] = DBNull.Value;
		else
		dr["Certificate_Status"] = CertificateStatus;
		
		if (CertificateNotificationStatus == null)
		dr["Certificate_NotificationStatus"] = DBNull.Value;
		else
		dr["Certificate_NotificationStatus"] = CertificateNotificationStatus;
		
		if (CertificationApprovedBy == null)
		dr["Certification_ApprovedBy"] = DBNull.Value;
		else
		dr["Certification_ApprovedBy"] = CertificationApprovedBy;
		
		if (CertificationExtra1 == null)
		dr["Certification_Extra1"] = DBNull.Value;
		else
		dr["Certification_Extra1"] = CertificationExtra1;
		
		if (CertificateExtra2 == null)
		dr["Certificate_Extra2"] = DBNull.Value;
		else
		dr["Certificate_Extra2"] = CertificateExtra2;
		
		if (CertificateExtra3 == null)
		dr["Certificate_Extra3"] = DBNull.Value;
		else
		dr["Certificate_Extra3"] = CertificateExtra3;
		
		if (CertificateExtra4 == null)
		dr["Certificate_Extra4"] = DBNull.Value;
		else
		dr["Certificate_Extra4"] = CertificateExtra4;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		CertificateId = dr["Certificate_Id"] != DBNull.Value ? Convert.ToInt64(dr["Certificate_Id"]) : CertificateId = null;
		CertificateName = dr["Certificate_Name"] != DBNull.Value ? Convert.ToString(dr["Certificate_Name"]) : CertificateName = null;
		CertificateForStudentId = dr["Certificate_ForStudentId"] != DBNull.Value ? Convert.ToInt64(dr["Certificate_ForStudentId"]) : CertificateForStudentId = null;
		CertificateForStandardId = dr["Certificate_ForStandardId"] != DBNull.Value ? Convert.ToInt64(dr["Certificate_ForStandardId"]) : CertificateForStandardId = null;
		CertificateForDivisionId = dr["Certificate_ForDivisionId"] != DBNull.Value ? Convert.ToInt64(dr["Certificate_ForDivisionId"]) : CertificateForDivisionId = null;
		CertificateRequestDate = dr["Certificate_RequestDate"] != DBNull.Value ? Convert.ToDateTime(dr["Certificate_RequestDate"]) : CertificateRequestDate = null;
		CertificateRequestedBy = dr["Certificate_RequestedBy"] != DBNull.Value ? Convert.ToString(dr["Certificate_RequestedBy"]) : CertificateRequestedBy = null;
		CertificateRequestedId = dr["Certificate_RequestedId"] != DBNull.Value ? Convert.ToInt64(dr["Certificate_RequestedId"]) : CertificateRequestedId = null;
		CertificateReason = dr["Certificate_Reason"] != DBNull.Value ? Convert.ToString(dr["Certificate_Reason"]) : CertificateReason = null;
		CertificateNextApplicationId = dr["Certificate_NextApplicationId"] != DBNull.Value ? Convert.ToInt64(dr["Certificate_NextApplicationId"]) : CertificateNextApplicationId = null;
		CertificatePrincipalLoginId = dr["Certificate_PrincipalLoginId"] != DBNull.Value ? Convert.ToInt64(dr["Certificate_PrincipalLoginId"]) : CertificatePrincipalLoginId = null;
		CertificateAccountManagerLoginId = dr["Certificate_AccountManagerLoginId"] != DBNull.Value ? Convert.ToInt64(dr["Certificate_AccountManagerLoginId"]) : CertificateAccountManagerLoginId = null;
		CertificateStockManagerLoginId = dr["Certificate_StockManagerLoginId"] != DBNull.Value ? Convert.ToInt64(dr["Certificate_StockManagerLoginId"]) : CertificateStockManagerLoginId = null;
		CertificateLibraryManagerLoginId = dr["Certificate_LibraryManagerLoginId"] != DBNull.Value ? Convert.ToInt64(dr["Certificate_LibraryManagerLoginId"]) : CertificateLibraryManagerLoginId = null;
		CertificatePrincipalApprovedStatus = dr["Certificate_PrincipalApprovedStatus"] != DBNull.Value ? Convert.ToString(dr["Certificate_PrincipalApprovedStatus"]) : CertificatePrincipalApprovedStatus = null;
		CertificateStockApprovedStatus = dr["Certificate_StockApprovedStatus"] != DBNull.Value ? Convert.ToString(dr["Certificate_StockApprovedStatus"]) : CertificateStockApprovedStatus = null;
		CertificateLibraryApprovedStatus = dr["Certificate_LibraryApprovedStatus"] != DBNull.Value ? Convert.ToString(dr["Certificate_LibraryApprovedStatus"]) : CertificateLibraryApprovedStatus = null;
		CertificateAccountApproveSatus = dr["Certificate_AccountApproveSatus"] != DBNull.Value ? Convert.ToString(dr["Certificate_AccountApproveSatus"]) : CertificateAccountApproveSatus = null;
		CertificatePrincipalApproveDate = dr["Certificate_PrincipalApproveDate"] != DBNull.Value ? Convert.ToDateTime(dr["Certificate_PrincipalApproveDate"]) : CertificatePrincipalApproveDate = null;
		CertificateStockApproveDate = dr["Certificate_StockApproveDate"] != DBNull.Value ? Convert.ToDateTime(dr["Certificate_StockApproveDate"]) : CertificateStockApproveDate = null;
		CertificateLibraryApproveDate = dr["Certificate_LibraryApproveDate"] != DBNull.Value ? Convert.ToDateTime(dr["Certificate_LibraryApproveDate"]) : CertificateLibraryApproveDate = null;
		CertificateAccountApprovedDate = dr["Certificate_AccountApprovedDate"] != DBNull.Value ? Convert.ToDateTime(dr["Certificate_AccountApprovedDate"]) : CertificateAccountApprovedDate = null;
		CertificateStatus = dr["Certificate_Status"] != DBNull.Value ? Convert.ToBoolean(dr["Certificate_Status"]) : CertificateStatus = null;
		CertificateNotificationStatus = dr["Certificate_NotificationStatus"] != DBNull.Value ? Convert.ToInt64(dr["Certificate_NotificationStatus"]) : CertificateNotificationStatus = null;
		CertificationApprovedBy = dr["Certification_ApprovedBy"] != DBNull.Value ? Convert.ToString(dr["Certification_ApprovedBy"]) : CertificationApprovedBy = null;
		CertificationExtra1 = dr["Certification_Extra1"] != DBNull.Value ? Convert.ToDateTime(dr["Certification_Extra1"]) : CertificationExtra1 = null;
		CertificateExtra2 = dr["Certificate_Extra2"] != DBNull.Value ? Convert.ToString(dr["Certificate_Extra2"]) : CertificateExtra2 = null;
		CertificateExtra3 = dr["Certificate_Extra3"] != DBNull.Value ? Convert.ToInt64(dr["Certificate_Extra3"]) : CertificateExtra3 = null;
		CertificateExtra4 = dr["Certificate_Extra4"] != DBNull.Value ? Convert.ToBoolean(dr["Certificate_Extra4"]) : CertificateExtra4 = null;
	}
	
	public static TMSCertificateDetails[] MapFrom(DataSet ds)
	{
		List<TMSCertificateDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSCertificateDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_CertificateDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_CertificateDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSCertificateDetails instance = new TMSCertificateDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSCertificateDetails Get(System.Int64 certificateId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSCertificateDetails instance;
		
		
		instance = new TMSCertificateDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCertificateDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, certificateId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0)// throw new ApplicationException("Could not get TMSCertificateDetails ID:" + certificateId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String certificateName, System.Int64? certificateForStudentId, System.Int64? certificateForStandardId, System.Int64? certificateForDivisionId, System.DateTime? certificateRequestDate, System.String certificateRequestedBy, System.Int64? certificateRequestedId, System.String certificateReason, System.Int64? certificateNextApplicationId, System.Int64? certificatePrincipalLoginId, System.Int64? certificateAccountManagerLoginId, System.Int64? certificateStockManagerLoginId, System.Int64? certificateLibraryManagerLoginId, System.String certificatePrincipalApprovedStatus, System.String certificateStockApprovedStatus, System.String certificateLibraryApprovedStatus, System.String certificateAccountApproveSatus, System.DateTime? certificatePrincipalApproveDate, System.DateTime? certificateStockApproveDate, System.DateTime? certificateLibraryApproveDate, System.DateTime? certificateAccountApprovedDate, System.Boolean? certificateStatus, System.Int64? certificateNotificationStatus, System.String certificationApprovedBy, System.DateTime? certificationExtra1, System.String certificateExtra2, System.Int64? certificateExtra3, System.Boolean? certificateExtra4, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCertificateDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, certificateName, certificateForStudentId, certificateForStandardId, certificateForDivisionId, certificateRequestDate, certificateRequestedBy, certificateRequestedId, certificateReason, certificateNextApplicationId, certificatePrincipalLoginId, certificateAccountManagerLoginId, certificateStockManagerLoginId, certificateLibraryManagerLoginId, certificatePrincipalApprovedStatus, certificateStockApprovedStatus, certificateLibraryApprovedStatus, certificateAccountApproveSatus, certificatePrincipalApproveDate, certificateStockApproveDate, certificateLibraryApproveDate, certificateAccountApprovedDate, certificateStatus, certificateNotificationStatus, certificationApprovedBy, certificationExtra1, certificateExtra2, certificateExtra3, certificateExtra4);
		
		if (transaction == null)
		this.CertificateId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.CertificateId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String certificateName, System.Int64? certificateForStudentId, System.Int64? certificateForStandardId, System.Int64? certificateForDivisionId, System.DateTime? certificateRequestDate, System.String certificateRequestedBy, System.Int64? certificateRequestedId, System.String certificateReason, System.Int64? certificateNextApplicationId, System.Int64? certificatePrincipalLoginId, System.Int64? certificateAccountManagerLoginId, System.Int64? certificateStockManagerLoginId, System.Int64? certificateLibraryManagerLoginId, System.String certificatePrincipalApprovedStatus, System.String certificateStockApprovedStatus, System.String certificateLibraryApprovedStatus, System.String certificateAccountApproveSatus, System.DateTime? certificatePrincipalApproveDate, System.DateTime? certificateStockApproveDate, System.DateTime? certificateLibraryApproveDate, System.DateTime? certificateAccountApprovedDate, System.Boolean? certificateStatus, System.Int64? certificateNotificationStatus, System.String certificationApprovedBy, System.DateTime? certificationExtra1, System.String certificateExtra2, System.Int64? certificateExtra3, System.Boolean? certificateExtra4)
	{
		Insert(certificateName, certificateForStudentId, certificateForStandardId, certificateForDivisionId, certificateRequestDate, certificateRequestedBy, certificateRequestedId, certificateReason, certificateNextApplicationId, certificatePrincipalLoginId, certificateAccountManagerLoginId, certificateStockManagerLoginId, certificateLibraryManagerLoginId, certificatePrincipalApprovedStatus, certificateStockApprovedStatus, certificateLibraryApprovedStatus, certificateAccountApproveSatus, certificatePrincipalApproveDate, certificateStockApproveDate, certificateLibraryApproveDate, certificateAccountApprovedDate, certificateStatus, certificateNotificationStatus, certificationApprovedBy, certificationExtra1, certificateExtra2, certificateExtra3, certificateExtra4, null);
	}
	/// <summary>
	/// Insert current TMSCertificateDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(CertificateName, CertificateForStudentId, CertificateForStandardId, CertificateForDivisionId, CertificateRequestDate, CertificateRequestedBy, CertificateRequestedId, CertificateReason, CertificateNextApplicationId, CertificatePrincipalLoginId, CertificateAccountManagerLoginId, CertificateStockManagerLoginId, CertificateLibraryManagerLoginId, CertificatePrincipalApprovedStatus, CertificateStockApprovedStatus, CertificateLibraryApprovedStatus, CertificateAccountApproveSatus, CertificatePrincipalApproveDate, CertificateStockApproveDate, CertificateLibraryApproveDate, CertificateAccountApprovedDate, CertificateStatus, CertificateNotificationStatus, CertificationApprovedBy, CertificationExtra1, CertificateExtra2, CertificateExtra3, CertificateExtra4, transaction);
	}
	
	/// <summary>
	/// Insert current TMSCertificateDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? certificateId, System.String certificateName, System.Int64? certificateForStudentId, System.Int64? certificateForStandardId, System.Int64? certificateForDivisionId, System.DateTime? certificateRequestDate, System.String certificateRequestedBy, System.Int64? certificateRequestedId, System.String certificateReason, System.Int64? certificateNextApplicationId, System.Int64? certificatePrincipalLoginId, System.Int64? certificateAccountManagerLoginId, System.Int64? certificateStockManagerLoginId, System.Int64? certificateLibraryManagerLoginId, System.String certificatePrincipalApprovedStatus, System.String certificateStockApprovedStatus, System.String certificateLibraryApprovedStatus, System.String certificateAccountApproveSatus, System.DateTime? certificatePrincipalApproveDate, System.DateTime? certificateStockApproveDate, System.DateTime? certificateLibraryApproveDate, System.DateTime? certificateAccountApprovedDate, System.Boolean? certificateStatus, System.Int64? certificateNotificationStatus, System.String certificationApprovedBy, System.DateTime? certificationExtra1, System.String certificateExtra2, System.Int64? certificateExtra3, System.Boolean? certificateExtra4, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCertificateDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@certificateId"].Value = certificateId;
		dbCommand.Parameters["@certificateName"].Value = certificateName;
		dbCommand.Parameters["@certificateForStudentId"].Value = certificateForStudentId;
		dbCommand.Parameters["@certificateForStandardId"].Value = certificateForStandardId;
		dbCommand.Parameters["@certificateForDivisionId"].Value = certificateForDivisionId;
		dbCommand.Parameters["@certificateRequestDate"].Value = certificateRequestDate;
		dbCommand.Parameters["@certificateRequestedBy"].Value = certificateRequestedBy;
		dbCommand.Parameters["@certificateRequestedId"].Value = certificateRequestedId;
		dbCommand.Parameters["@certificateReason"].Value = certificateReason;
		dbCommand.Parameters["@certificateNextApplicationId"].Value = certificateNextApplicationId;
		dbCommand.Parameters["@certificatePrincipalLoginId"].Value = certificatePrincipalLoginId;
		dbCommand.Parameters["@certificateAccountManagerLoginId"].Value = certificateAccountManagerLoginId;
		dbCommand.Parameters["@certificateStockManagerLoginId"].Value = certificateStockManagerLoginId;
		dbCommand.Parameters["@certificateLibraryManagerLoginId"].Value = certificateLibraryManagerLoginId;
		dbCommand.Parameters["@certificatePrincipalApprovedStatus"].Value = certificatePrincipalApprovedStatus;
		dbCommand.Parameters["@certificateStockApprovedStatus"].Value = certificateStockApprovedStatus;
		dbCommand.Parameters["@certificateLibraryApprovedStatus"].Value = certificateLibraryApprovedStatus;
		dbCommand.Parameters["@certificateAccountApproveSatus"].Value = certificateAccountApproveSatus;
		dbCommand.Parameters["@certificatePrincipalApproveDate"].Value = certificatePrincipalApproveDate;
		dbCommand.Parameters["@certificateStockApproveDate"].Value = certificateStockApproveDate;
		dbCommand.Parameters["@certificateLibraryApproveDate"].Value = certificateLibraryApproveDate;
		dbCommand.Parameters["@certificateAccountApprovedDate"].Value = certificateAccountApprovedDate;
		dbCommand.Parameters["@certificateStatus"].Value = certificateStatus;
		dbCommand.Parameters["@certificateNotificationStatus"].Value = certificateNotificationStatus;
		dbCommand.Parameters["@certificationApprovedBy"].Value = certificationApprovedBy;
		dbCommand.Parameters["@certificationExtra1"].Value = certificationExtra1;
		dbCommand.Parameters["@certificateExtra2"].Value = certificateExtra2;
		dbCommand.Parameters["@certificateExtra3"].Value = certificateExtra3;
		dbCommand.Parameters["@certificateExtra4"].Value = certificateExtra4;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? certificateId, System.String certificateName, System.Int64? certificateForStudentId, System.Int64? certificateForStandardId, System.Int64? certificateForDivisionId, System.DateTime? certificateRequestDate, System.String certificateRequestedBy, System.Int64? certificateRequestedId, System.String certificateReason, System.Int64? certificateNextApplicationId, System.Int64? certificatePrincipalLoginId, System.Int64? certificateAccountManagerLoginId, System.Int64? certificateStockManagerLoginId, System.Int64? certificateLibraryManagerLoginId, System.String certificatePrincipalApprovedStatus, System.String certificateStockApprovedStatus, System.String certificateLibraryApprovedStatus, System.String certificateAccountApproveSatus, System.DateTime? certificatePrincipalApproveDate, System.DateTime? certificateStockApproveDate, System.DateTime? certificateLibraryApproveDate, System.DateTime? certificateAccountApprovedDate, System.Boolean? certificateStatus, System.Int64? certificateNotificationStatus, System.String certificationApprovedBy, System.DateTime? certificationExtra1, System.String certificateExtra2, System.Int64? certificateExtra3, System.Boolean? certificateExtra4)
	{
		Update(certificateId, certificateName, certificateForStudentId, certificateForStandardId, certificateForDivisionId, certificateRequestDate, certificateRequestedBy, certificateRequestedId, certificateReason, certificateNextApplicationId, certificatePrincipalLoginId, certificateAccountManagerLoginId, certificateStockManagerLoginId, certificateLibraryManagerLoginId, certificatePrincipalApprovedStatus, certificateStockApprovedStatus, certificateLibraryApprovedStatus, certificateAccountApproveSatus, certificatePrincipalApproveDate, certificateStockApproveDate, certificateLibraryApproveDate, certificateAccountApprovedDate, certificateStatus, certificateNotificationStatus, certificationApprovedBy, certificationExtra1, certificateExtra2, certificateExtra3, certificateExtra4, null);
	}
	
	public static void Update(TMSCertificateDetails tMSCertificateDetails)
	{
		tMSCertificateDetails.Update();
	}
	
	public static void Update(TMSCertificateDetails tMSCertificateDetails, DbTransaction transaction)
	{
		tMSCertificateDetails.Update(transaction);
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Update(DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCertificateDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@certificateId"].SourceColumn = "Certificate_Id";
		dbCommand.Parameters["@certificateName"].SourceColumn = "Certificate_Name";
		dbCommand.Parameters["@certificateForStudentId"].SourceColumn = "Certificate_ForStudentId";
		dbCommand.Parameters["@certificateForStandardId"].SourceColumn = "Certificate_ForStandardId";
		dbCommand.Parameters["@certificateForDivisionId"].SourceColumn = "Certificate_ForDivisionId";
		dbCommand.Parameters["@certificateRequestDate"].SourceColumn = "Certificate_RequestDate";
		dbCommand.Parameters["@certificateRequestedBy"].SourceColumn = "Certificate_RequestedBy";
		dbCommand.Parameters["@certificateRequestedId"].SourceColumn = "Certificate_RequestedId";
		dbCommand.Parameters["@certificateReason"].SourceColumn = "Certificate_Reason";
		dbCommand.Parameters["@certificateNextApplicationId"].SourceColumn = "Certificate_NextApplicationId";
		dbCommand.Parameters["@certificatePrincipalLoginId"].SourceColumn = "Certificate_PrincipalLoginId";
		dbCommand.Parameters["@certificateAccountManagerLoginId"].SourceColumn = "Certificate_AccountManagerLoginId";
		dbCommand.Parameters["@certificateStockManagerLoginId"].SourceColumn = "Certificate_StockManagerLoginId";
		dbCommand.Parameters["@certificateLibraryManagerLoginId"].SourceColumn = "Certificate_LibraryManagerLoginId";
		dbCommand.Parameters["@certificatePrincipalApprovedStatus"].SourceColumn = "Certificate_PrincipalApprovedStatus";
		dbCommand.Parameters["@certificateStockApprovedStatus"].SourceColumn = "Certificate_StockApprovedStatus";
		dbCommand.Parameters["@certificateLibraryApprovedStatus"].SourceColumn = "Certificate_LibraryApprovedStatus";
		dbCommand.Parameters["@certificateAccountApproveSatus"].SourceColumn = "Certificate_AccountApproveSatus";
		dbCommand.Parameters["@certificatePrincipalApproveDate"].SourceColumn = "Certificate_PrincipalApproveDate";
		dbCommand.Parameters["@certificateStockApproveDate"].SourceColumn = "Certificate_StockApproveDate";
		dbCommand.Parameters["@certificateLibraryApproveDate"].SourceColumn = "Certificate_LibraryApproveDate";
		dbCommand.Parameters["@certificateAccountApprovedDate"].SourceColumn = "Certificate_AccountApprovedDate";
		dbCommand.Parameters["@certificateStatus"].SourceColumn = "Certificate_Status";
		dbCommand.Parameters["@certificateNotificationStatus"].SourceColumn = "Certificate_NotificationStatus";
		dbCommand.Parameters["@certificationApprovedBy"].SourceColumn = "Certification_ApprovedBy";
		dbCommand.Parameters["@certificationExtra1"].SourceColumn = "Certification_Extra1";
		dbCommand.Parameters["@certificateExtra2"].SourceColumn = "Certificate_Extra2";
		dbCommand.Parameters["@certificateExtra3"].SourceColumn = "Certificate_Extra3";
		dbCommand.Parameters["@certificateExtra4"].SourceColumn = "Certificate_Extra4";
		
		ds = new DataSet();
		this.MapTo( ds );
		ds.AcceptChanges();
		ds.Tables[0].Rows[0].SetModified();
		if (transaction == null)
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, UpdateBehavior.Standard);
		else
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, transaction);
		return;
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	public void Update()
	{
		this.Update((DbTransaction)null);
	}
	#endregion
	
	
	#region DELETE
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, false)]
	public static void Delete(System.Int64? certificateId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCertificateDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, certificateId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
	public static void Delete(System.Int64? certificateId)
	{
		Delete(
		certificateId);
	}
	
	/// <summary>
	/// Delete current TMSCertificateDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCertificateDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, CertificateId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.CertificateId = null;
	}
	
	/// <summary>
	/// Delete current TMSCertificateDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSCertificateDetails[] Search(System.Int64? certificateId, System.String certificateName, System.Int64? certificateForStudentId, System.Int64? certificateForStandardId, System.Int64? certificateForDivisionId, System.DateTime? certificateRequestDate, System.String certificateRequestedBy, System.Int64? certificateRequestedId, System.String certificateReason, System.Int64? certificateNextApplicationId, System.Int64? certificatePrincipalLoginId, System.Int64? certificateAccountManagerLoginId, System.Int64? certificateStockManagerLoginId, System.Int64? certificateLibraryManagerLoginId, System.String certificatePrincipalApprovedStatus, System.String certificateStockApprovedStatus, System.String certificateLibraryApprovedStatus, System.String certificateAccountApproveSatus, System.DateTime? certificatePrincipalApproveDate, System.DateTime? certificateStockApproveDate, System.DateTime? certificateLibraryApproveDate, System.DateTime? certificateAccountApprovedDate, System.Boolean? certificateStatus, System.Int64? certificateNotificationStatus, System.String certificationApprovedBy, System.DateTime? certificationExtra1, System.String certificateExtra2, System.Int64? certificateExtra3, System.Boolean? certificateExtra4)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCertificateDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, certificateId, certificateName, certificateForStudentId, certificateForStandardId, certificateForDivisionId, certificateRequestDate, certificateRequestedBy, certificateRequestedId, certificateReason, certificateNextApplicationId, certificatePrincipalLoginId, certificateAccountManagerLoginId, certificateStockManagerLoginId, certificateLibraryManagerLoginId, certificatePrincipalApprovedStatus, certificateStockApprovedStatus, certificateLibraryApprovedStatus, certificateAccountApproveSatus, certificatePrincipalApproveDate, certificateStockApproveDate, certificateLibraryApproveDate, certificateAccountApprovedDate, certificateStatus, certificateNotificationStatus, certificationApprovedBy, certificationExtra1, certificateExtra2, certificateExtra3, certificateExtra4);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSCertificateDetails.MapFrom(ds);
	}
	
	
	public static TMSCertificateDetails[] Search(TMSCertificateDetails searchObject)
	{
		return Search ( searchObject.CertificateId, searchObject.CertificateName, searchObject.CertificateForStudentId, searchObject.CertificateForStandardId, searchObject.CertificateForDivisionId, searchObject.CertificateRequestDate, searchObject.CertificateRequestedBy, searchObject.CertificateRequestedId, searchObject.CertificateReason, searchObject.CertificateNextApplicationId, searchObject.CertificatePrincipalLoginId, searchObject.CertificateAccountManagerLoginId, searchObject.CertificateStockManagerLoginId, searchObject.CertificateLibraryManagerLoginId, searchObject.CertificatePrincipalApprovedStatus, searchObject.CertificateStockApprovedStatus, searchObject.CertificateLibraryApprovedStatus, searchObject.CertificateAccountApproveSatus, searchObject.CertificatePrincipalApproveDate, searchObject.CertificateStockApproveDate, searchObject.CertificateLibraryApproveDate, searchObject.CertificateAccountApprovedDate, searchObject.CertificateStatus, searchObject.CertificateNotificationStatus, searchObject.CertificationApprovedBy, searchObject.CertificationExtra1, searchObject.CertificateExtra2, searchObject.CertificateExtra3, searchObject.CertificateExtra4);
	}
	
	/// <summary>
	/// Returns all TMSCertificateDetails objects.
	/// </summary>
	/// <returns>List of all TMSCertificateDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSCertificateDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

