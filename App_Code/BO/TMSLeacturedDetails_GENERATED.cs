/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/12/2012 2:58:21 PM                                    */
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
public partial class TMSLeacturedDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_LeacturedDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ldLeacturedDetailsId;
	private System.Int64? _ldSubjectId;
	private System.Int64? _ldFacultyId;
	private System.Int64? _ldSchoolCatId;
	private System.Int64? _ldSubSchoolCatId;
	private System.String _ldWeekDays;
	private System.Int64? _ldLeactureTimeId;
	private System.String _ldExtra1;
	private System.DateTime? _ldDate;
	private System.Int32? _ldStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? LDLeacturedDetailsId
	{
		get
		{
			return _ldLeacturedDetailsId;
		}
		set
		{
			_ldLeacturedDetailsId = value;
		}
	}
	
	public System.Int64? LDSubjectId
	{
		get
		{
			return _ldSubjectId;
		}
		set
		{
			_ldSubjectId = value;
		}
	}
	
	public System.Int64? LDFacultyId
	{
		get
		{
			return _ldFacultyId;
		}
		set
		{
			_ldFacultyId = value;
		}
	}
	
	public System.Int64? LDSchoolCatId
	{
		get
		{
			return _ldSchoolCatId;
		}
		set
		{
			_ldSchoolCatId = value;
		}
	}
	
	public System.Int64? LDSubSchoolCatId
	{
		get
		{
			return _ldSubSchoolCatId;
		}
		set
		{
			_ldSubSchoolCatId = value;
		}
	}
	
	public System.String LDWeekDays
	{
		get
		{
			return _ldWeekDays;
		}
		set
		{
			_ldWeekDays = value;
		}
	}
	
	public System.Int64? LDLeactureTimeId
	{
		get
		{
			return _ldLeactureTimeId;
		}
		set
		{
			_ldLeactureTimeId = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("LD_LeacturedDetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_SchoolCatId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_SubSchoolCatId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_WeekDays", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_LeactureTimeId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_Extra1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("LD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (LDLeacturedDetailsId == null)
		dr["LD_LeacturedDetailsId"] = DBNull.Value;
		else
		dr["LD_LeacturedDetailsId"] = LDLeacturedDetailsId;
		
		if (LDSubjectId == null)
		dr["LD_SubjectId"] = DBNull.Value;
		else
		dr["LD_SubjectId"] = LDSubjectId;
		
		if (LDFacultyId == null)
		dr["LD_FacultyId"] = DBNull.Value;
		else
		dr["LD_FacultyId"] = LDFacultyId;
		
		if (LDSchoolCatId == null)
		dr["LD_SchoolCatId"] = DBNull.Value;
		else
		dr["LD_SchoolCatId"] = LDSchoolCatId;
		
		if (LDSubSchoolCatId == null)
		dr["LD_SubSchoolCatId"] = DBNull.Value;
		else
		dr["LD_SubSchoolCatId"] = LDSubSchoolCatId;
		
		if (LDWeekDays == null)
		dr["LD_WeekDays"] = DBNull.Value;
		else
		dr["LD_WeekDays"] = LDWeekDays;
		
		if (LDLeactureTimeId == null)
		dr["LD_LeactureTimeId"] = DBNull.Value;
		else
		dr["LD_LeactureTimeId"] = LDLeactureTimeId;
		
		if (LDExtra1 == null)
		dr["LD_Extra1"] = DBNull.Value;
		else
		dr["LD_Extra1"] = LDExtra1;
		
		if (LDDate == null)
		dr["LD_Date"] = DBNull.Value;
		else
		dr["LD_Date"] = LDDate;
		
		if (LDStatus == null)
		dr["LD_Status"] = DBNull.Value;
		else
		dr["LD_Status"] = LDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		LDLeacturedDetailsId = dr["LD_LeacturedDetailsId"] != DBNull.Value ? Convert.ToInt64(dr["LD_LeacturedDetailsId"]) : LDLeacturedDetailsId = null;
		LDSubjectId = dr["LD_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["LD_SubjectId"]) : LDSubjectId = null;
		LDFacultyId = dr["LD_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["LD_FacultyId"]) : LDFacultyId = null;
		LDSchoolCatId = dr["LD_SchoolCatId"] != DBNull.Value ? Convert.ToInt64(dr["LD_SchoolCatId"]) : LDSchoolCatId = null;
		LDSubSchoolCatId = dr["LD_SubSchoolCatId"] != DBNull.Value ? Convert.ToInt64(dr["LD_SubSchoolCatId"]) : LDSubSchoolCatId = null;
		LDWeekDays = dr["LD_WeekDays"] != DBNull.Value ? Convert.ToString(dr["LD_WeekDays"]) : LDWeekDays = null;
		LDLeactureTimeId = dr["LD_LeactureTimeId"] != DBNull.Value ? Convert.ToInt64(dr["LD_LeactureTimeId"]) : LDLeactureTimeId = null;
		LDExtra1 = dr["LD_Extra1"] != DBNull.Value ? Convert.ToString(dr["LD_Extra1"]) : LDExtra1 = null;
		LDDate = dr["LD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["LD_Date"]) : LDDate = null;
		LDStatus = dr["LD_Status"] != DBNull.Value ? Convert.ToInt32(dr["LD_Status"]) : LDStatus = null;
	}
	
	public static TMSLeacturedDetails[] MapFrom(DataSet ds)
	{
		List<TMSLeacturedDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSLeacturedDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_LeacturedDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_LeacturedDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSLeacturedDetails instance = new TMSLeacturedDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSLeacturedDetails Get(System.Int64 ldLeacturedDetailsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSLeacturedDetails instance;
		
		
		instance = new TMSLeacturedDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeacturedDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ldLeacturedDetailsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSLeacturedDetails ID:" + ldLeacturedDetailsId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? ldSubjectId, System.Int64? ldFacultyId, System.Int64? ldSchoolCatId, System.Int64? ldSubSchoolCatId, System.String ldWeekDays, System.Int64? ldLeactureTimeId, System.String ldExtra1, System.DateTime? ldDate, System.Int32? ldStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeacturedDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ldSubjectId, ldFacultyId, ldSchoolCatId, ldSubSchoolCatId, ldWeekDays, ldLeactureTimeId, ldExtra1, ldDate, ldStatus);
		
		if (transaction == null)
		this.LDLeacturedDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.LDLeacturedDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? ldSubjectId, System.Int64? ldFacultyId, System.Int64? ldSchoolCatId, System.Int64? ldSubSchoolCatId, System.String ldWeekDays, System.Int64? ldLeactureTimeId, System.String ldExtra1, System.DateTime? ldDate, System.Int32? ldStatus)
	{
		Insert(ldSubjectId, ldFacultyId, ldSchoolCatId, ldSubSchoolCatId, ldWeekDays, ldLeactureTimeId, ldExtra1, ldDate, ldStatus, null);
	}
	/// <summary>
	/// Insert current TMSLeacturedDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(LDSubjectId, LDFacultyId, LDSchoolCatId, LDSubSchoolCatId, LDWeekDays, LDLeactureTimeId, LDExtra1, LDDate, LDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSLeacturedDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ldLeacturedDetailsId, System.Int64? ldSubjectId, System.Int64? ldFacultyId, System.Int64? ldSchoolCatId, System.Int64? ldSubSchoolCatId, System.String ldWeekDays, System.Int64? ldLeactureTimeId, System.String ldExtra1, System.DateTime? ldDate, System.Int32? ldStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeacturedDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ldLeacturedDetailsId"].Value = ldLeacturedDetailsId;
		dbCommand.Parameters["@ldSubjectId"].Value = ldSubjectId;
		dbCommand.Parameters["@ldFacultyId"].Value = ldFacultyId;
		dbCommand.Parameters["@ldSchoolCatId"].Value = ldSchoolCatId;
		dbCommand.Parameters["@ldSubSchoolCatId"].Value = ldSubSchoolCatId;
		dbCommand.Parameters["@ldWeekDays"].Value = ldWeekDays;
		dbCommand.Parameters["@ldLeactureTimeId"].Value = ldLeactureTimeId;
		dbCommand.Parameters["@ldExtra1"].Value = ldExtra1;
		dbCommand.Parameters["@ldDate"].Value = ldDate;
		dbCommand.Parameters["@ldStatus"].Value = ldStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ldLeacturedDetailsId, System.Int64? ldSubjectId, System.Int64? ldFacultyId, System.Int64? ldSchoolCatId, System.Int64? ldSubSchoolCatId, System.String ldWeekDays, System.Int64? ldLeactureTimeId, System.String ldExtra1, System.DateTime? ldDate, System.Int32? ldStatus)
	{
		Update(ldLeacturedDetailsId, ldSubjectId, ldFacultyId, ldSchoolCatId, ldSubSchoolCatId, ldWeekDays, ldLeactureTimeId, ldExtra1, ldDate, ldStatus, null);
	}
	
	public static void Update(TMSLeacturedDetails tMSLeacturedDetails)
	{
		tMSLeacturedDetails.Update();
	}
	
	public static void Update(TMSLeacturedDetails tMSLeacturedDetails, DbTransaction transaction)
	{
		tMSLeacturedDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSLeacturedDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ldLeacturedDetailsId"].SourceColumn = "LD_LeacturedDetailsId";
		dbCommand.Parameters["@ldSubjectId"].SourceColumn = "LD_SubjectId";
		dbCommand.Parameters["@ldFacultyId"].SourceColumn = "LD_FacultyId";
		dbCommand.Parameters["@ldSchoolCatId"].SourceColumn = "LD_SchoolCatId";
		dbCommand.Parameters["@ldSubSchoolCatId"].SourceColumn = "LD_SubSchoolCatId";
		dbCommand.Parameters["@ldWeekDays"].SourceColumn = "LD_WeekDays";
		dbCommand.Parameters["@ldLeactureTimeId"].SourceColumn = "LD_LeactureTimeId";
		dbCommand.Parameters["@ldExtra1"].SourceColumn = "LD_Extra1";
		dbCommand.Parameters["@ldDate"].SourceColumn = "LD_Date";
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
	public static void Delete(System.Int64? ldLeacturedDetailsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeacturedDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ldLeacturedDetailsId);
		
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
	public static void Delete(System.Int64? ldLeacturedDetailsId)
	{
		Delete(
		ldLeacturedDetailsId);
	}
	
	/// <summary>
	/// Delete current TMSLeacturedDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeacturedDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, LDLeacturedDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.LDLeacturedDetailsId = null;
	}
	
	/// <summary>
	/// Delete current TMSLeacturedDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSLeacturedDetails[] Search(System.Int64? ldLeacturedDetailsId, System.Int64? ldSubjectId, System.Int64? ldFacultyId, System.Int64? ldSchoolCatId, System.Int64? ldSubSchoolCatId, System.String ldWeekDays, System.Int64? ldLeactureTimeId, System.String ldExtra1, System.DateTime? ldDate, System.Int32? ldStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSLeacturedDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ldLeacturedDetailsId, ldSubjectId, ldFacultyId, ldSchoolCatId, ldSubSchoolCatId, ldWeekDays, ldLeactureTimeId, ldExtra1, ldDate, ldStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSLeacturedDetails.MapFrom(ds);
	}
	
	
	public static TMSLeacturedDetails[] Search(TMSLeacturedDetails searchObject)
	{
		return Search ( searchObject.LDLeacturedDetailsId, searchObject.LDSubjectId, searchObject.LDFacultyId, searchObject.LDSchoolCatId, searchObject.LDSubSchoolCatId, searchObject.LDWeekDays, searchObject.LDLeactureTimeId, searchObject.LDExtra1, searchObject.LDDate, searchObject.LDStatus);
	}
	
	/// <summary>
	/// Returns all TMSLeacturedDetails objects.
	/// </summary>
	/// <returns>List of all TMSLeacturedDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSLeacturedDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

