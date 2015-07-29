/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 10/9/2012 12:03:32 PM                                    */
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
public partial class TMSApplicationDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ApplicationDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _adApplicationId;
	private System.Int64? _adSenderId;
	private System.Int64? _adReceivedId;
	private System.Int64? _adReplyID;
	private System.String _adApplicationFor;
	private System.String _adSubject;
	private System.String _adDescription;
	private System.DateTime? _adLeaveFromDate;
	private System.DateTime? _adLeaveToDate;
	private System.DateTime? _adDate;
	private System.Int32? _adStatus;
	private System.Int64? _adMinitorID;
	private System.String _adSentTo;
	private System.String _adExtra1;
	private System.String _adExtra2;
	private System.String _adCasualLeave;
	private System.String _adPaidLeave;
	private System.String _adSickLeave;
	private System.String _adEarnedLeave;
	private System.String _adOtherLeave;
	private System.String _adApproveStatus;
	private System.Int64? _adApproveByID;
	private System.String _adApproveByType;
	private System.DateTime? _adApproveDate;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ADApplicationId
	{
		get
		{
			return _adApplicationId;
		}
		set
		{
			_adApplicationId = value;
		}
	}
	
	public System.Int64? ADSenderId
	{
		get
		{
			return _adSenderId;
		}
		set
		{
			_adSenderId = value;
		}
	}
	
	public System.Int64? ADReceivedId
	{
		get
		{
			return _adReceivedId;
		}
		set
		{
			_adReceivedId = value;
		}
	}
	
	public System.Int64? ADReplyID
	{
		get
		{
			return _adReplyID;
		}
		set
		{
			_adReplyID = value;
		}
	}
	
	public System.String ADApplicationFor
	{
		get
		{
			return _adApplicationFor;
		}
		set
		{
			_adApplicationFor = value;
		}
	}
	
	public System.String ADSubject
	{
		get
		{
			return _adSubject;
		}
		set
		{
			_adSubject = value;
		}
	}
	
	public System.String ADDescription
	{
		get
		{
			return _adDescription;
		}
		set
		{
			_adDescription = value;
		}
	}
	
	public System.DateTime? ADLeaveFromDate
	{
		get
		{
			return _adLeaveFromDate;
		}
		set
		{
			_adLeaveFromDate = value;
		}
	}
	
	public System.DateTime? ADLeaveToDate
	{
		get
		{
			return _adLeaveToDate;
		}
		set
		{
			_adLeaveToDate = value;
		}
	}
	
	public System.DateTime? ADDate
	{
		get
		{
			return _adDate;
		}
		set
		{
			_adDate = value;
		}
	}
	
	public System.Int32? ADStatus
	{
		get
		{
			return _adStatus;
		}
		set
		{
			_adStatus = value;
		}
	}
	
	public System.Int64? ADMinitorID
	{
		get
		{
			return _adMinitorID;
		}
		set
		{
			_adMinitorID = value;
		}
	}
	
	public System.String ADSentTo
	{
		get
		{
			return _adSentTo;
		}
		set
		{
			_adSentTo = value;
		}
	}
	
	public System.String ADExtra1
	{
		get
		{
			return _adExtra1;
		}
		set
		{
			_adExtra1 = value;
		}
	}
	
	public System.String ADExtra2
	{
		get
		{
			return _adExtra2;
		}
		set
		{
			_adExtra2 = value;
		}
	}
	
	public System.String ADCasualLeave
	{
		get
		{
			return _adCasualLeave;
		}
		set
		{
			_adCasualLeave = value;
		}
	}
	
	public System.String ADPaidLeave
	{
		get
		{
			return _adPaidLeave;
		}
		set
		{
			_adPaidLeave = value;
		}
	}
	
	public System.String ADSickLeave
	{
		get
		{
			return _adSickLeave;
		}
		set
		{
			_adSickLeave = value;
		}
	}
	
	public System.String ADEarnedLeave
	{
		get
		{
			return _adEarnedLeave;
		}
		set
		{
			_adEarnedLeave = value;
		}
	}
	
	public System.String ADOtherLeave
	{
		get
		{
			return _adOtherLeave;
		}
		set
		{
			_adOtherLeave = value;
		}
	}
	
	public System.String ADApproveStatus
	{
		get
		{
			return _adApproveStatus;
		}
		set
		{
			_adApproveStatus = value;
		}
	}
	
	public System.Int64? ADApproveByID
	{
		get
		{
			return _adApproveByID;
		}
		set
		{
			_adApproveByID = value;
		}
	}
	
	public System.String ADApproveByType
	{
		get
		{
			return _adApproveByType;
		}
		set
		{
			_adApproveByType = value;
		}
	}
	
	public System.DateTime? ADApproveDate
	{
		get
		{
			return _adApproveDate;
		}
		set
		{
			_adApproveDate = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("AD_ApplicationId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_SenderId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_ReceivedId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_ReplyID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_ApplicationFor", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Subject", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_LeaveFromDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_LeaveToDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Status", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_MinitorID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_SentTo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Extra1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_Extra2", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_CasualLeave", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_PaidLeave", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_SickLeave", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_EarnedLeave", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_OtherLeave", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_ApproveStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_ApproveByID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_ApproveByType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AD_ApproveDate", typeof(System.DateTime) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ADApplicationId == null)
		dr["AD_ApplicationId"] = DBNull.Value;
		else
		dr["AD_ApplicationId"] = ADApplicationId;
		
		if (ADSenderId == null)
		dr["AD_SenderId"] = DBNull.Value;
		else
		dr["AD_SenderId"] = ADSenderId;
		
		if (ADReceivedId == null)
		dr["AD_ReceivedId"] = DBNull.Value;
		else
		dr["AD_ReceivedId"] = ADReceivedId;
		
		if (ADReplyID == null)
		dr["AD_ReplyID"] = DBNull.Value;
		else
		dr["AD_ReplyID"] = ADReplyID;
		
		if (ADApplicationFor == null)
		dr["AD_ApplicationFor"] = DBNull.Value;
		else
		dr["AD_ApplicationFor"] = ADApplicationFor;
		
		if (ADSubject == null)
		dr["AD_Subject"] = DBNull.Value;
		else
		dr["AD_Subject"] = ADSubject;
		
		if (ADDescription == null)
		dr["AD_Description"] = DBNull.Value;
		else
		dr["AD_Description"] = ADDescription;
		
		if (ADLeaveFromDate == null)
		dr["AD_LeaveFromDate"] = DBNull.Value;
		else
		dr["AD_LeaveFromDate"] = ADLeaveFromDate;
		
		if (ADLeaveToDate == null)
		dr["AD_LeaveToDate"] = DBNull.Value;
		else
		dr["AD_LeaveToDate"] = ADLeaveToDate;
		
		if (ADDate == null)
		dr["AD_Date"] = DBNull.Value;
		else
		dr["AD_Date"] = ADDate;
		
		if (ADStatus == null)
		dr["AD_Status"] = DBNull.Value;
		else
		dr["AD_Status"] = ADStatus;
		
		if (ADMinitorID == null)
		dr["AD_MinitorID"] = DBNull.Value;
		else
		dr["AD_MinitorID"] = ADMinitorID;
		
		if (ADSentTo == null)
		dr["AD_SentTo"] = DBNull.Value;
		else
		dr["AD_SentTo"] = ADSentTo;
		
		if (ADExtra1 == null)
		dr["AD_Extra1"] = DBNull.Value;
		else
		dr["AD_Extra1"] = ADExtra1;
		
		if (ADExtra2 == null)
		dr["AD_Extra2"] = DBNull.Value;
		else
		dr["AD_Extra2"] = ADExtra2;
		
		if (ADCasualLeave == null)
		dr["AD_CasualLeave"] = DBNull.Value;
		else
		dr["AD_CasualLeave"] = ADCasualLeave;
		
		if (ADPaidLeave == null)
		dr["AD_PaidLeave"] = DBNull.Value;
		else
		dr["AD_PaidLeave"] = ADPaidLeave;
		
		if (ADSickLeave == null)
		dr["AD_SickLeave"] = DBNull.Value;
		else
		dr["AD_SickLeave"] = ADSickLeave;
		
		if (ADEarnedLeave == null)
		dr["AD_EarnedLeave"] = DBNull.Value;
		else
		dr["AD_EarnedLeave"] = ADEarnedLeave;
		
		if (ADOtherLeave == null)
		dr["AD_OtherLeave"] = DBNull.Value;
		else
		dr["AD_OtherLeave"] = ADOtherLeave;
		
		if (ADApproveStatus == null)
		dr["AD_ApproveStatus"] = DBNull.Value;
		else
		dr["AD_ApproveStatus"] = ADApproveStatus;
		
		if (ADApproveByID == null)
		dr["AD_ApproveByID"] = DBNull.Value;
		else
		dr["AD_ApproveByID"] = ADApproveByID;
		
		if (ADApproveByType == null)
		dr["AD_ApproveByType"] = DBNull.Value;
		else
		dr["AD_ApproveByType"] = ADApproveByType;
		
		if (ADApproveDate == null)
		dr["AD_ApproveDate"] = DBNull.Value;
		else
		dr["AD_ApproveDate"] = ADApproveDate;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ADApplicationId = dr["AD_ApplicationId"] != DBNull.Value ? Convert.ToInt64(dr["AD_ApplicationId"]) : ADApplicationId = null;
		ADSenderId = dr["AD_SenderId"] != DBNull.Value ? Convert.ToInt64(dr["AD_SenderId"]) : ADSenderId = null;
		ADReceivedId = dr["AD_ReceivedId"] != DBNull.Value ? Convert.ToInt64(dr["AD_ReceivedId"]) : ADReceivedId = null;
		ADReplyID = dr["AD_ReplyID"] != DBNull.Value ? Convert.ToInt64(dr["AD_ReplyID"]) : ADReplyID = null;
		ADApplicationFor = dr["AD_ApplicationFor"] != DBNull.Value ? Convert.ToString(dr["AD_ApplicationFor"]) : ADApplicationFor = null;
		ADSubject = dr["AD_Subject"] != DBNull.Value ? Convert.ToString(dr["AD_Subject"]) : ADSubject = null;
		ADDescription = dr["AD_Description"] != DBNull.Value ? Convert.ToString(dr["AD_Description"]) : ADDescription = null;
		ADLeaveFromDate = dr["AD_LeaveFromDate"] != DBNull.Value ? Convert.ToDateTime(dr["AD_LeaveFromDate"]) : ADLeaveFromDate = null;
		ADLeaveToDate = dr["AD_LeaveToDate"] != DBNull.Value ? Convert.ToDateTime(dr["AD_LeaveToDate"]) : ADLeaveToDate = null;
		ADDate = dr["AD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["AD_Date"]) : ADDate = null;
		ADStatus = dr["AD_Status"] != DBNull.Value ? Convert.ToInt32(dr["AD_Status"]) : ADStatus = null;
		ADMinitorID = dr["AD_MinitorID"] != DBNull.Value ? Convert.ToInt64(dr["AD_MinitorID"]) : ADMinitorID = null;
		ADSentTo = dr["AD_SentTo"] != DBNull.Value ? Convert.ToString(dr["AD_SentTo"]) : ADSentTo = null;
		ADExtra1 = dr["AD_Extra1"] != DBNull.Value ? Convert.ToString(dr["AD_Extra1"]) : ADExtra1 = null;
		ADExtra2 = dr["AD_Extra2"] != DBNull.Value ? Convert.ToString(dr["AD_Extra2"]) : ADExtra2 = null;
		ADCasualLeave = dr["AD_CasualLeave"] != DBNull.Value ? Convert.ToString(dr["AD_CasualLeave"]) : ADCasualLeave = null;
		ADPaidLeave = dr["AD_PaidLeave"] != DBNull.Value ? Convert.ToString(dr["AD_PaidLeave"]) : ADPaidLeave = null;
		ADSickLeave = dr["AD_SickLeave"] != DBNull.Value ? Convert.ToString(dr["AD_SickLeave"]) : ADSickLeave = null;
		ADEarnedLeave = dr["AD_EarnedLeave"] != DBNull.Value ? Convert.ToString(dr["AD_EarnedLeave"]) : ADEarnedLeave = null;
		ADOtherLeave = dr["AD_OtherLeave"] != DBNull.Value ? Convert.ToString(dr["AD_OtherLeave"]) : ADOtherLeave = null;
		ADApproveStatus = dr["AD_ApproveStatus"] != DBNull.Value ? Convert.ToString(dr["AD_ApproveStatus"]) : ADApproveStatus = null;
		ADApproveByID = dr["AD_ApproveByID"] != DBNull.Value ? Convert.ToInt64(dr["AD_ApproveByID"]) : ADApproveByID = null;
		ADApproveByType = dr["AD_ApproveByType"] != DBNull.Value ? Convert.ToString(dr["AD_ApproveByType"]) : ADApproveByType = null;
		ADApproveDate = dr["AD_ApproveDate"] != DBNull.Value ? Convert.ToDateTime(dr["AD_ApproveDate"]) : ADApproveDate = null;
	}
	
	public static TMSApplicationDetails[] MapFrom(DataSet ds)
	{
		List<TMSApplicationDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSApplicationDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ApplicationDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ApplicationDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSApplicationDetails instance = new TMSApplicationDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSApplicationDetails Get(System.Int64 adApplicationId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSApplicationDetails instance;
		
		
		instance = new TMSApplicationDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adApplicationId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSApplicationDetails ID:" + adApplicationId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? adSenderId, System.Int64? adReceivedId, System.Int64? adReplyID, System.String adApplicationFor, System.String adSubject, System.String adDescription, System.DateTime? adLeaveFromDate, System.DateTime? adLeaveToDate, System.DateTime? adDate, System.Int32? adStatus, System.Int64? adMinitorID, System.String adSentTo, System.String adExtra1, System.String adExtra2, System.String adCasualLeave, System.String adPaidLeave, System.String adSickLeave, System.String adEarnedLeave, System.String adOtherLeave, System.String adApproveStatus, System.Int64? adApproveByID, System.String adApproveByType, System.DateTime? adApproveDate, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adSenderId, adReceivedId, adReplyID, adApplicationFor, adSubject, adDescription, adLeaveFromDate, adLeaveToDate, adDate, adStatus, adMinitorID, adSentTo, adExtra1, adExtra2, adCasualLeave, adPaidLeave, adSickLeave, adEarnedLeave, adOtherLeave, adApproveStatus, adApproveByID, adApproveByType, adApproveDate);
		
		if (transaction == null)
		this.ADApplicationId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ADApplicationId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? adSenderId, System.Int64? adReceivedId, System.Int64? adReplyID, System.String adApplicationFor, System.String adSubject, System.String adDescription, System.DateTime? adLeaveFromDate, System.DateTime? adLeaveToDate, System.DateTime? adDate, System.Int32? adStatus, System.Int64? adMinitorID, System.String adSentTo, System.String adExtra1, System.String adExtra2, System.String adCasualLeave, System.String adPaidLeave, System.String adSickLeave, System.String adEarnedLeave, System.String adOtherLeave, System.String adApproveStatus, System.Int64? adApproveByID, System.String adApproveByType, System.DateTime? adApproveDate)
	{
		Insert(adSenderId, adReceivedId, adReplyID, adApplicationFor, adSubject, adDescription, adLeaveFromDate, adLeaveToDate, adDate, adStatus, adMinitorID, adSentTo, adExtra1, adExtra2, adCasualLeave, adPaidLeave, adSickLeave, adEarnedLeave, adOtherLeave, adApproveStatus, adApproveByID, adApproveByType, adApproveDate, null);
	}
	/// <summary>
	/// Insert current TMSApplicationDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ADSenderId, ADReceivedId, ADReplyID, ADApplicationFor, ADSubject, ADDescription, ADLeaveFromDate, ADLeaveToDate, ADDate, ADStatus, ADMinitorID, ADSentTo, ADExtra1, ADExtra2, ADCasualLeave, ADPaidLeave, ADSickLeave, ADEarnedLeave, ADOtherLeave, ADApproveStatus, ADApproveByID, ADApproveByType, ADApproveDate, transaction);
	}
	
	/// <summary>
	/// Insert current TMSApplicationDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? adApplicationId, System.Int64? adSenderId, System.Int64? adReceivedId, System.Int64? adReplyID, System.String adApplicationFor, System.String adSubject, System.String adDescription, System.DateTime? adLeaveFromDate, System.DateTime? adLeaveToDate, System.DateTime? adDate, System.Int32? adStatus, System.Int64? adMinitorID, System.String adSentTo, System.String adExtra1, System.String adExtra2, System.String adCasualLeave, System.String adPaidLeave, System.String adSickLeave, System.String adEarnedLeave, System.String adOtherLeave, System.String adApproveStatus, System.Int64? adApproveByID, System.String adApproveByType, System.DateTime? adApproveDate, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@adApplicationId"].Value = adApplicationId;
		dbCommand.Parameters["@adSenderId"].Value = adSenderId;
		dbCommand.Parameters["@adReceivedId"].Value = adReceivedId;
		dbCommand.Parameters["@adReplyID"].Value = adReplyID;
		dbCommand.Parameters["@adApplicationFor"].Value = adApplicationFor;
		dbCommand.Parameters["@adSubject"].Value = adSubject;
		dbCommand.Parameters["@adDescription"].Value = adDescription;
		dbCommand.Parameters["@adLeaveFromDate"].Value = adLeaveFromDate;
		dbCommand.Parameters["@adLeaveToDate"].Value = adLeaveToDate;
		dbCommand.Parameters["@adDate"].Value = adDate;
		dbCommand.Parameters["@adStatus"].Value = adStatus;
		dbCommand.Parameters["@adMinitorID"].Value = adMinitorID;
		dbCommand.Parameters["@adSentTo"].Value = adSentTo;
		dbCommand.Parameters["@adExtra1"].Value = adExtra1;
		dbCommand.Parameters["@adExtra2"].Value = adExtra2;
		dbCommand.Parameters["@adCasualLeave"].Value = adCasualLeave;
		dbCommand.Parameters["@adPaidLeave"].Value = adPaidLeave;
		dbCommand.Parameters["@adSickLeave"].Value = adSickLeave;
		dbCommand.Parameters["@adEarnedLeave"].Value = adEarnedLeave;
		dbCommand.Parameters["@adOtherLeave"].Value = adOtherLeave;
		dbCommand.Parameters["@adApproveStatus"].Value = adApproveStatus;
		dbCommand.Parameters["@adApproveByID"].Value = adApproveByID;
		dbCommand.Parameters["@adApproveByType"].Value = adApproveByType;
		dbCommand.Parameters["@adApproveDate"].Value = adApproveDate;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? adApplicationId, System.Int64? adSenderId, System.Int64? adReceivedId, System.Int64? adReplyID, System.String adApplicationFor, System.String adSubject, System.String adDescription, System.DateTime? adLeaveFromDate, System.DateTime? adLeaveToDate, System.DateTime? adDate, System.Int32? adStatus, System.Int64? adMinitorID, System.String adSentTo, System.String adExtra1, System.String adExtra2, System.String adCasualLeave, System.String adPaidLeave, System.String adSickLeave, System.String adEarnedLeave, System.String adOtherLeave, System.String adApproveStatus, System.Int64? adApproveByID, System.String adApproveByType, System.DateTime? adApproveDate)
	{
		Update(adApplicationId, adSenderId, adReceivedId, adReplyID, adApplicationFor, adSubject, adDescription, adLeaveFromDate, adLeaveToDate, adDate, adStatus, adMinitorID, adSentTo, adExtra1, adExtra2, adCasualLeave, adPaidLeave, adSickLeave, adEarnedLeave, adOtherLeave, adApproveStatus, adApproveByID, adApproveByType, adApproveDate, null);
	}
	
	public static void Update(TMSApplicationDetails tMSApplicationDetails)
	{
		tMSApplicationDetails.Update();
	}
	
	public static void Update(TMSApplicationDetails tMSApplicationDetails, DbTransaction transaction)
	{
		tMSApplicationDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSApplicationDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@adApplicationId"].SourceColumn = "AD_ApplicationId";
		dbCommand.Parameters["@adSenderId"].SourceColumn = "AD_SenderId";
		dbCommand.Parameters["@adReceivedId"].SourceColumn = "AD_ReceivedId";
		dbCommand.Parameters["@adReplyID"].SourceColumn = "AD_ReplyID";
		dbCommand.Parameters["@adApplicationFor"].SourceColumn = "AD_ApplicationFor";
		dbCommand.Parameters["@adSubject"].SourceColumn = "AD_Subject";
		dbCommand.Parameters["@adDescription"].SourceColumn = "AD_Description";
		dbCommand.Parameters["@adLeaveFromDate"].SourceColumn = "AD_LeaveFromDate";
		dbCommand.Parameters["@adLeaveToDate"].SourceColumn = "AD_LeaveToDate";
		dbCommand.Parameters["@adDate"].SourceColumn = "AD_Date";
		dbCommand.Parameters["@adStatus"].SourceColumn = "AD_Status";
		dbCommand.Parameters["@adMinitorID"].SourceColumn = "AD_MinitorID";
		dbCommand.Parameters["@adSentTo"].SourceColumn = "AD_SentTo";
		dbCommand.Parameters["@adExtra1"].SourceColumn = "AD_Extra1";
		dbCommand.Parameters["@adExtra2"].SourceColumn = "AD_Extra2";
		dbCommand.Parameters["@adCasualLeave"].SourceColumn = "AD_CasualLeave";
		dbCommand.Parameters["@adPaidLeave"].SourceColumn = "AD_PaidLeave";
		dbCommand.Parameters["@adSickLeave"].SourceColumn = "AD_SickLeave";
		dbCommand.Parameters["@adEarnedLeave"].SourceColumn = "AD_EarnedLeave";
		dbCommand.Parameters["@adOtherLeave"].SourceColumn = "AD_OtherLeave";
		dbCommand.Parameters["@adApproveStatus"].SourceColumn = "AD_ApproveStatus";
		dbCommand.Parameters["@adApproveByID"].SourceColumn = "AD_ApproveByID";
		dbCommand.Parameters["@adApproveByType"].SourceColumn = "AD_ApproveByType";
		dbCommand.Parameters["@adApproveDate"].SourceColumn = "AD_ApproveDate";
		
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
	public static void Delete(System.Int64? adApplicationId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adApplicationId);
		
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
	public static void Delete(System.Int64? adApplicationId)
	{
		Delete(
		adApplicationId);
	}
	
	/// <summary>
	/// Delete current TMSApplicationDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ADApplicationId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ADApplicationId = null;
	}
	
	/// <summary>
	/// Delete current TMSApplicationDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSApplicationDetails[] Search(System.Int64? adApplicationId, System.Int64? adSenderId, System.Int64? adReceivedId, System.Int64? adReplyID, System.String adApplicationFor, System.String adSubject, System.String adDescription, System.DateTime? adLeaveFromDate, System.DateTime? adLeaveToDate, System.DateTime? adDate, System.Int32? adStatus, System.Int64? adMinitorID, System.String adSentTo, System.String adExtra1, System.String adExtra2, System.String adCasualLeave, System.String adPaidLeave, System.String adSickLeave, System.String adEarnedLeave, System.String adOtherLeave, System.String adApproveStatus, System.Int64? adApproveByID, System.String adApproveByType, System.DateTime? adApproveDate)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSApplicationDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, adApplicationId, adSenderId, adReceivedId, adReplyID, adApplicationFor, adSubject, adDescription, adLeaveFromDate, adLeaveToDate, adDate, adStatus, adMinitorID, adSentTo, adExtra1, adExtra2, adCasualLeave, adPaidLeave, adSickLeave, adEarnedLeave, adOtherLeave, adApproveStatus, adApproveByID, adApproveByType, adApproveDate);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSApplicationDetails.MapFrom(ds);
	}
	
	
	public static TMSApplicationDetails[] Search(TMSApplicationDetails searchObject)
	{
		return Search ( searchObject.ADApplicationId, searchObject.ADSenderId, searchObject.ADReceivedId, searchObject.ADReplyID, searchObject.ADApplicationFor, searchObject.ADSubject, searchObject.ADDescription, searchObject.ADLeaveFromDate, searchObject.ADLeaveToDate, searchObject.ADDate, searchObject.ADStatus, searchObject.ADMinitorID, searchObject.ADSentTo, searchObject.ADExtra1, searchObject.ADExtra2, searchObject.ADCasualLeave, searchObject.ADPaidLeave, searchObject.ADSickLeave, searchObject.ADEarnedLeave, searchObject.ADOtherLeave, searchObject.ADApproveStatus, searchObject.ADApproveByID, searchObject.ADApproveByType, searchObject.ADApproveDate);
	}
	
	/// <summary>
	/// Returns all TMSApplicationDetails objects.
	/// </summary>
	/// <returns>List of all TMSApplicationDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSApplicationDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

