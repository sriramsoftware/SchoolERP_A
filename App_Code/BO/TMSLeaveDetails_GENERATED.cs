/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 9/12/2012 2:42:15 PM                                    */
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
public partial class TMSLeaveDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_LeaveDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ldLeaveDetailsId;
	private System.Int64? _ldFacultyLoginId;
	private System.String _ldFacultyType;
	private System.Int32? _ldCasualLeave;
	private System.Int32? _ldEarnedLeave;
	private System.Int32? _ldPaidLeave;
	private System.Int32? _ldSickLeave;
	private System.Int32? _ldOtherLeave;
	private System.Int32? _ldMartialLeave;
	private System.Int32? _ldMartinityLeave;
	private System.String _ldExtra1;
	private System.String _ldExtra2;
	private System.DateTime? _ldDate;
	private System.String _ldYear;
	private System.Int64? _ldAddedById;
	private System.String _ldAddedByRemarks;
	private System.String _ldOtherRemark;
	private System.Int32? _ldStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? LDLeaveDetailsId
	{
		get
		{
			return _ldLeaveDetailsId;
		}
		set
		{
			_ldLeaveDetailsId = value;
		}
	}
	
	public System.Int64? LDFacultyLoginId
	{
		get
		{
			return _ldFacultyLoginId;
		}
		set
		{
			_ldFacultyLoginId = value;
		}
	}
	
	public System.String LDFacultyType
	{
		get
		{
			return _ldFacultyType;
		}
		set
		{
			_ldFacultyType = value;
		}
	}
	
	public System.Int32? LDCasualLeave
	{
		get
		{
			return _ldCasualLeave;
		}
		set
		{
			_ldCasualLeave = value;
		}
	}
	
	public System.Int32? LDEarnedLeave
	{
		get
		{
			return _ldEarnedLeave;
		}
		set
		{
			_ldEarnedLeave = value;
		}
	}
	
	public System.Int32? LDPaidLeave
	{
		get
		{
			return _ldPaidLeave;
		}
		set
		{
			_ldPaidLeave = value;
		}
	}
	
	public System.Int32? LDSickLeave
	{
		get
		{
			return _ldSickLeave;
		}
		set
		{
			_ldSickLeave = value;
		}
	}
	
	public System.Int32? LDOtherLeave
	{
		get
		{
			return _ldOtherLeave;
		}
		set
		{
			_ldOtherLeave = value;
		}
	}
	
	public System.Int32? LDMartialLeave
	{
		get
		{
			return _ldMartialLeave;
		}
		set
		{
			_ldMartialLeave = value;
		}
	}
	
	public System.Int32? LDMartinityLeave
	{
		get
		{
			return _ldMartinityLeave;
		}
		set
		{
			_ldMartinityLeave = value;
		}
	}
	
	public System.String LDExtra1
	{
		get
		{
			return _ldExtra1;
		}
		set
		{
			_ldExtra1 = value;
		}
	}
	
	public System.String LDExtra2
	{
		get
		{
			return _ldExtra2;
		}
		set
		{
			_ldExtra2 = value;
		}
	}
	
	public System.DateTime? LDDate
	{
		get
		{
			return _ldDate;
		}
		set
		{
			_ldDate = value;
		}
	}
	
	public System.String LDYear
	{
		get
		{
			return _ldYear;
		}
		set
		{
			_ldYear = value;
		}
	}
	
	public System.Int64? LDAddedById
	{
		get
		{
			return _ldAddedById;
		}
		set
		{
			_ldAddedById = value;
		}
	}
	
	public System.String LDAddedByRemarks
	{
		get
		{
			return _ldAddedByRemarks;
		}
		set
		{
			_ldAddedByRemarks = value;
		}
	}
	
	public System.String LDOtherRemark
	{
		get
		{
			return _ldOtherRemark;
		}
		set
		{
			_ldOtherRemark = value;
		}
	}
	
	public System.Int32? LDStatus
	{
		get
		{
			return _ldStatus;
		}
		set
		{
			_ldStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("LD_LeaveDetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_FacultyLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_FacultyType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_CasualLeave", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_EarnedLeave", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_PaidLeave", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_SickLeave", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_OtherLeave", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_MartialLeave", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_MartinityLeave", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_Extra1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_Extra2", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_Year", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_AddedByRemarks", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_OtherRemark", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (LDLeaveDetailsId == null)
		dr["LD_LeaveDetailsId"] = DBNull.Value;
		else
		dr["LD_LeaveDetailsId"] = LDLeaveDetailsId;
		
		if (LDFacultyLoginId == null)
		dr["LD_FacultyLoginId"] = DBNull.Value;
		else
		dr["LD_FacultyLoginId"] = LDFacultyLoginId;
		
		if (LDFacultyType == null)
		dr["LD_FacultyType"] = DBNull.Value;
		else
		dr["LD_FacultyType"] = LDFacultyType;
		
		if (LDCasualLeave == null)
		dr["LD_CasualLeave"] = DBNull.Value;
		else
		dr["LD_CasualLeave"] = LDCasualLeave;
		
		if (LDEarnedLeave == null)
		dr["LD_EarnedLeave"] = DBNull.Value;
		else
		dr["LD_EarnedLeave"] = LDEarnedLeave;
		
		if (LDPaidLeave == null)
		dr["LD_PaidLeave"] = DBNull.Value;
		else
		dr["LD_PaidLeave"] = LDPaidLeave;
		
		if (LDSickLeave == null)
		dr["LD_SickLeave"] = DBNull.Value;
		else
		dr["LD_SickLeave"] = LDSickLeave;
		
		if (LDOtherLeave == null)
		dr["LD_OtherLeave"] = DBNull.Value;
		else
		dr["LD_OtherLeave"] = LDOtherLeave;
		
		if (LDMartialLeave == null)
		dr["LD_MartialLeave"] = DBNull.Value;
		else
		dr["LD_MartialLeave"] = LDMartialLeave;
		
		if (LDMartinityLeave == null)
		dr["LD_MartinityLeave"] = DBNull.Value;
		else
		dr["LD_MartinityLeave"] = LDMartinityLeave;
		
		if (LDExtra1 == null)
		dr["LD_Extra1"] = DBNull.Value;
		else
		dr["LD_Extra1"] = LDExtra1;
		
		if (LDExtra2 == null)
		dr["LD_Extra2"] = DBNull.Value;
		else
		dr["LD_Extra2"] = LDExtra2;
		
		if (LDDate == null)
		dr["LD_Date"] = DBNull.Value;
		else
		dr["LD_Date"] = LDDate;
		
		if (LDYear == null)
		dr["LD_Year"] = DBNull.Value;
		else
		dr["LD_Year"] = LDYear;
		
		if (LDAddedById == null)
		dr["LD_AddedById"] = DBNull.Value;
		else
		dr["LD_AddedById"] = LDAddedById;
		
		if (LDAddedByRemarks == null)
		dr["LD_AddedByRemarks"] = DBNull.Value;
		else
		dr["LD_AddedByRemarks"] = LDAddedByRemarks;
		
		if (LDOtherRemark == null)
		dr["LD_OtherRemark"] = DBNull.Value;
		else
		dr["LD_OtherRemark"] = LDOtherRemark;
		
		if (LDStatus == null)
		dr["LD_Status"] = DBNull.Value;
		else
		dr["LD_Status"] = LDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		LDLeaveDetailsId = dr["LD_LeaveDetailsId"] != DBNull.Value ? Convert.ToInt64(dr["LD_LeaveDetailsId"]) : LDLeaveDetailsId = null;
		LDFacultyLoginId = dr["LD_FacultyLoginId"] != DBNull.Value ? Convert.ToInt64(dr["LD_FacultyLoginId"]) : LDFacultyLoginId = null;
		LDFacultyType = dr["LD_FacultyType"] != DBNull.Value ? Convert.ToString(dr["LD_FacultyType"]) : LDFacultyType = null;
		LDCasualLeave = dr["LD_CasualLeave"] != DBNull.Value ? Convert.ToInt32(dr["LD_CasualLeave"]) : LDCasualLeave = null;
		LDEarnedLeave = dr["LD_EarnedLeave"] != DBNull.Value ? Convert.ToInt32(dr["LD_EarnedLeave"]) : LDEarnedLeave = null;
		LDPaidLeave = dr["LD_PaidLeave"] != DBNull.Value ? Convert.ToInt32(dr["LD_PaidLeave"]) : LDPaidLeave = null;
		LDSickLeave = dr["LD_SickLeave"] != DBNull.Value ? Convert.ToInt32(dr["LD_SickLeave"]) : LDSickLeave = null;
		LDOtherLeave = dr["LD_OtherLeave"] != DBNull.Value ? Convert.ToInt32(dr["LD_OtherLeave"]) : LDOtherLeave = null;
		LDMartialLeave = dr["LD_MartialLeave"] != DBNull.Value ? Convert.ToInt32(dr["LD_MartialLeave"]) : LDMartialLeave = null;
		LDMartinityLeave = dr["LD_MartinityLeave"] != DBNull.Value ? Convert.ToInt32(dr["LD_MartinityLeave"]) : LDMartinityLeave = null;
		LDExtra1 = dr["LD_Extra1"] != DBNull.Value ? Convert.ToString(dr["LD_Extra1"]) : LDExtra1 = null;
		LDExtra2 = dr["LD_Extra2"] != DBNull.Value ? Convert.ToString(dr["LD_Extra2"]) : LDExtra2 = null;
		LDDate = dr["LD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["LD_Date"]) : LDDate = null;
		LDYear = dr["LD_Year"] != DBNull.Value ? Convert.ToString(dr["LD_Year"]) : LDYear = null;
		LDAddedById = dr["LD_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["LD_AddedById"]) : LDAddedById = null;
		LDAddedByRemarks = dr["LD_AddedByRemarks"] != DBNull.Value ? Convert.ToString(dr["LD_AddedByRemarks"]) : LDAddedByRemarks = null;
		LDOtherRemark = dr["LD_OtherRemark"] != DBNull.Value ? Convert.ToString(dr["LD_OtherRemark"]) : LDOtherRemark = null;
		LDStatus = dr["LD_Status"] != DBNull.Value ? Convert.ToInt32(dr["LD_Status"]) : LDStatus = null;
	}
	
	public static TMSLeaveDetails[] MapFrom(DataSet ds)
	{
		List<TMSLeaveDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSLeaveDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_LeaveDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_LeaveDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSLeaveDetails instance = new TMSLeaveDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSLeaveDetails Get(System.Int64 ldLeaveDetailsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSLeaveDetails instance;
		
		
		instance = new TMSLeaveDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeaveDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ldLeaveDetailsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSLeaveDetails ID:" + ldLeaveDetailsId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? ldFacultyLoginId, System.String ldFacultyType, System.Int32? ldCasualLeave, System.Int32? ldEarnedLeave, System.Int32? ldPaidLeave, System.Int32? ldSickLeave, System.Int32? ldOtherLeave, System.Int32? ldMartialLeave, System.Int32? ldMartinityLeave, System.String ldExtra1, System.String ldExtra2, System.DateTime? ldDate, System.String ldYear, System.Int64? ldAddedById, System.String ldAddedByRemarks, System.String ldOtherRemark, System.Int32? ldStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeaveDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ldFacultyLoginId, ldFacultyType, ldCasualLeave, ldEarnedLeave, ldPaidLeave, ldSickLeave, ldOtherLeave, ldMartialLeave, ldMartinityLeave, ldExtra1, ldExtra2, ldDate, ldYear, ldAddedById, ldAddedByRemarks, ldOtherRemark, ldStatus);
		
		if (transaction == null)
		this.LDLeaveDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.LDLeaveDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? ldFacultyLoginId, System.String ldFacultyType, System.Int32? ldCasualLeave, System.Int32? ldEarnedLeave, System.Int32? ldPaidLeave, System.Int32? ldSickLeave, System.Int32? ldOtherLeave, System.Int32? ldMartialLeave, System.Int32? ldMartinityLeave, System.String ldExtra1, System.String ldExtra2, System.DateTime? ldDate, System.String ldYear, System.Int64? ldAddedById, System.String ldAddedByRemarks, System.String ldOtherRemark, System.Int32? ldStatus)
	{
		Insert(ldFacultyLoginId, ldFacultyType, ldCasualLeave, ldEarnedLeave, ldPaidLeave, ldSickLeave, ldOtherLeave, ldMartialLeave, ldMartinityLeave, ldExtra1, ldExtra2, ldDate, ldYear, ldAddedById, ldAddedByRemarks, ldOtherRemark, ldStatus, null);
	}
	/// <summary>
	/// Insert current TMSLeaveDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(LDFacultyLoginId, LDFacultyType, LDCasualLeave, LDEarnedLeave, LDPaidLeave, LDSickLeave, LDOtherLeave, LDMartialLeave, LDMartinityLeave, LDExtra1, LDExtra2, LDDate, LDYear, LDAddedById, LDAddedByRemarks, LDOtherRemark, LDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSLeaveDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ldLeaveDetailsId, System.Int64? ldFacultyLoginId, System.String ldFacultyType, System.Int32? ldCasualLeave, System.Int32? ldEarnedLeave, System.Int32? ldPaidLeave, System.Int32? ldSickLeave, System.Int32? ldOtherLeave, System.Int32? ldMartialLeave, System.Int32? ldMartinityLeave, System.String ldExtra1, System.String ldExtra2, System.DateTime? ldDate, System.String ldYear, System.Int64? ldAddedById, System.String ldAddedByRemarks, System.String ldOtherRemark, System.Int32? ldStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeaveDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ldLeaveDetailsId"].Value = ldLeaveDetailsId;
		dbCommand.Parameters["@ldFacultyLoginId"].Value = ldFacultyLoginId;
		dbCommand.Parameters["@ldFacultyType"].Value = ldFacultyType;
		dbCommand.Parameters["@ldCasualLeave"].Value = ldCasualLeave;
		dbCommand.Parameters["@ldEarnedLeave"].Value = ldEarnedLeave;
		dbCommand.Parameters["@ldPaidLeave"].Value = ldPaidLeave;
		dbCommand.Parameters["@ldSickLeave"].Value = ldSickLeave;
		dbCommand.Parameters["@ldOtherLeave"].Value = ldOtherLeave;
		dbCommand.Parameters["@ldMartialLeave"].Value = ldMartialLeave;
		dbCommand.Parameters["@ldMartinityLeave"].Value = ldMartinityLeave;
		dbCommand.Parameters["@ldExtra1"].Value = ldExtra1;
		dbCommand.Parameters["@ldExtra2"].Value = ldExtra2;
		dbCommand.Parameters["@ldDate"].Value = ldDate;
		dbCommand.Parameters["@ldYear"].Value = ldYear;
		dbCommand.Parameters["@ldAddedById"].Value = ldAddedById;
		dbCommand.Parameters["@ldAddedByRemarks"].Value = ldAddedByRemarks;
		dbCommand.Parameters["@ldOtherRemark"].Value = ldOtherRemark;
		dbCommand.Parameters["@ldStatus"].Value = ldStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ldLeaveDetailsId, System.Int64? ldFacultyLoginId, System.String ldFacultyType, System.Int32? ldCasualLeave, System.Int32? ldEarnedLeave, System.Int32? ldPaidLeave, System.Int32? ldSickLeave, System.Int32? ldOtherLeave, System.Int32? ldMartialLeave, System.Int32? ldMartinityLeave, System.String ldExtra1, System.String ldExtra2, System.DateTime? ldDate, System.String ldYear, System.Int64? ldAddedById, System.String ldAddedByRemarks, System.String ldOtherRemark, System.Int32? ldStatus)
	{
		Update(ldLeaveDetailsId, ldFacultyLoginId, ldFacultyType, ldCasualLeave, ldEarnedLeave, ldPaidLeave, ldSickLeave, ldOtherLeave, ldMartialLeave, ldMartinityLeave, ldExtra1, ldExtra2, ldDate, ldYear, ldAddedById, ldAddedByRemarks, ldOtherRemark, ldStatus, null);
	}
	
	public static void Update(TMSLeaveDetails tMSLeaveDetails)
	{
		tMSLeaveDetails.Update();
	}
	
	public static void Update(TMSLeaveDetails tMSLeaveDetails, DbTransaction transaction)
	{
		tMSLeaveDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSLeaveDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ldLeaveDetailsId"].SourceColumn = "LD_LeaveDetailsId";
		dbCommand.Parameters["@ldFacultyLoginId"].SourceColumn = "LD_FacultyLoginId";
		dbCommand.Parameters["@ldFacultyType"].SourceColumn = "LD_FacultyType";
		dbCommand.Parameters["@ldCasualLeave"].SourceColumn = "LD_CasualLeave";
		dbCommand.Parameters["@ldEarnedLeave"].SourceColumn = "LD_EarnedLeave";
		dbCommand.Parameters["@ldPaidLeave"].SourceColumn = "LD_PaidLeave";
		dbCommand.Parameters["@ldSickLeave"].SourceColumn = "LD_SickLeave";
		dbCommand.Parameters["@ldOtherLeave"].SourceColumn = "LD_OtherLeave";
		dbCommand.Parameters["@ldMartialLeave"].SourceColumn = "LD_MartialLeave";
		dbCommand.Parameters["@ldMartinityLeave"].SourceColumn = "LD_MartinityLeave";
		dbCommand.Parameters["@ldExtra1"].SourceColumn = "LD_Extra1";
		dbCommand.Parameters["@ldExtra2"].SourceColumn = "LD_Extra2";
		dbCommand.Parameters["@ldDate"].SourceColumn = "LD_Date";
		dbCommand.Parameters["@ldYear"].SourceColumn = "LD_Year";
		dbCommand.Parameters["@ldAddedById"].SourceColumn = "LD_AddedById";
		dbCommand.Parameters["@ldAddedByRemarks"].SourceColumn = "LD_AddedByRemarks";
		dbCommand.Parameters["@ldOtherRemark"].SourceColumn = "LD_OtherRemark";
		dbCommand.Parameters["@ldStatus"].SourceColumn = "LD_Status";
		
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
	public static void Delete(System.Int64? ldLeaveDetailsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeaveDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ldLeaveDetailsId);
		
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
	public static void Delete(System.Int64? ldLeaveDetailsId)
	{
		Delete(
		ldLeaveDetailsId);
	}
	
	/// <summary>
	/// Delete current TMSLeaveDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeaveDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, LDLeaveDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.LDLeaveDetailsId = null;
	}
	
	/// <summary>
	/// Delete current TMSLeaveDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSLeaveDetails[] Search(System.Int64? ldLeaveDetailsId, System.Int64? ldFacultyLoginId, System.String ldFacultyType, System.Int32? ldCasualLeave, System.Int32? ldEarnedLeave, System.Int32? ldPaidLeave, System.Int32? ldSickLeave, System.Int32? ldOtherLeave, System.Int32? ldMartialLeave, System.Int32? ldMartinityLeave, System.String ldExtra1, System.String ldExtra2, System.DateTime? ldDate, System.String ldYear, System.Int64? ldAddedById, System.String ldAddedByRemarks, System.String ldOtherRemark, System.Int32? ldStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeaveDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ldLeaveDetailsId, ldFacultyLoginId, ldFacultyType, ldCasualLeave, ldEarnedLeave, ldPaidLeave, ldSickLeave, ldOtherLeave, ldMartialLeave, ldMartinityLeave, ldExtra1, ldExtra2, ldDate, ldYear, ldAddedById, ldAddedByRemarks, ldOtherRemark, ldStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSLeaveDetails.MapFrom(ds);
	}
	
	
	public static TMSLeaveDetails[] Search(TMSLeaveDetails searchObject)
	{
		return Search ( searchObject.LDLeaveDetailsId, searchObject.LDFacultyLoginId, searchObject.LDFacultyType, searchObject.LDCasualLeave, searchObject.LDEarnedLeave, searchObject.LDPaidLeave, searchObject.LDSickLeave, searchObject.LDOtherLeave, searchObject.LDMartialLeave, searchObject.LDMartinityLeave, searchObject.LDExtra1, searchObject.LDExtra2, searchObject.LDDate, searchObject.LDYear, searchObject.LDAddedById, searchObject.LDAddedByRemarks, searchObject.LDOtherRemark, searchObject.LDStatus);
	}
	
	/// <summary>
	/// Returns all TMSLeaveDetails objects.
	/// </summary>
	/// <returns>List of all TMSLeaveDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSLeaveDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

