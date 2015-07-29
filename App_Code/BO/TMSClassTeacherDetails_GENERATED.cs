/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/14/2012 1:09:13 PM                                    */
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
public partial class TMSClassTeacherDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ClassTeacherDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ctdClassTeacherId;
	private System.Int64? _ctdSchoolCatId;
	private System.Int64? _ctdSchoolSubCatId;
	private System.Int64? _ctdSubjectId;
	private System.Int64? _ctdFacultyId;
	private System.String _ctdAssignBy;
	private System.DateTime? _ctdDate;
	private System.Int32? _ctdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? CTDClassTeacherId
	{
		get
		{
			return _ctdClassTeacherId;
		}
		set
		{
			_ctdClassTeacherId = value;
		}
	}
	
	public System.Int64? CTDSchoolCatId
	{
		get
		{
			return _ctdSchoolCatId;
		}
		set
		{
			_ctdSchoolCatId = value;
		}
	}
	
	public System.Int64? CTDSchoolSubCatId
	{
		get
		{
			return _ctdSchoolSubCatId;
		}
		set
		{
			_ctdSchoolSubCatId = value;
		}
	}
	
	public System.Int64? CTDSubjectId
	{
		get
		{
			return _ctdSubjectId;
		}
		set
		{
			_ctdSubjectId = value;
		}
	}
	
	public System.Int64? CTDFacultyId
	{
		get
		{
			return _ctdFacultyId;
		}
		set
		{
			_ctdFacultyId = value;
		}
	}
	
	public System.String CTDAssignBy
	{
		get
		{
			return _ctdAssignBy;
		}
		set
		{
			_ctdAssignBy = value;
		}
	}
	
	public System.DateTime? CTDDate
	{
		get
		{
			return _ctdDate;
		}
		set
		{
			_ctdDate = value;
		}
	}
	
	public System.Int32? CTDStatus
	{
		get
		{
			return _ctdStatus;
		}
		set
		{
			_ctdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("CTD_ClassTeacherId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CTD_SchoolCatId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CTD_SchoolSubCatId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CTD_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CTD_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CTD_AssignBy", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CTD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("CTD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (CTDClassTeacherId == null)
		dr["CTD_ClassTeacherId"] = DBNull.Value;
		else
		dr["CTD_ClassTeacherId"] = CTDClassTeacherId;
		
		if (CTDSchoolCatId == null)
		dr["CTD_SchoolCatId"] = DBNull.Value;
		else
		dr["CTD_SchoolCatId"] = CTDSchoolCatId;
		
		if (CTDSchoolSubCatId == null)
		dr["CTD_SchoolSubCatId"] = DBNull.Value;
		else
		dr["CTD_SchoolSubCatId"] = CTDSchoolSubCatId;
		
		if (CTDSubjectId == null)
		dr["CTD_SubjectId"] = DBNull.Value;
		else
		dr["CTD_SubjectId"] = CTDSubjectId;
		
		if (CTDFacultyId == null)
		dr["CTD_FacultyId"] = DBNull.Value;
		else
		dr["CTD_FacultyId"] = CTDFacultyId;
		
		if (CTDAssignBy == null)
		dr["CTD_AssignBy"] = DBNull.Value;
		else
		dr["CTD_AssignBy"] = CTDAssignBy;
		
		if (CTDDate == null)
		dr["CTD_Date"] = DBNull.Value;
		else
		dr["CTD_Date"] = CTDDate;
		
		if (CTDStatus == null)
		dr["CTD_Status"] = DBNull.Value;
		else
		dr["CTD_Status"] = CTDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		CTDClassTeacherId = dr["CTD_ClassTeacherId"] != DBNull.Value ? Convert.ToInt64(dr["CTD_ClassTeacherId"]) : CTDClassTeacherId = null;
		CTDSchoolCatId = dr["CTD_SchoolCatId"] != DBNull.Value ? Convert.ToInt64(dr["CTD_SchoolCatId"]) : CTDSchoolCatId = null;
		CTDSchoolSubCatId = dr["CTD_SchoolSubCatId"] != DBNull.Value ? Convert.ToInt64(dr["CTD_SchoolSubCatId"]) : CTDSchoolSubCatId = null;
		CTDSubjectId = dr["CTD_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["CTD_SubjectId"]) : CTDSubjectId = null;
		CTDFacultyId = dr["CTD_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["CTD_FacultyId"]) : CTDFacultyId = null;
		CTDAssignBy = dr["CTD_AssignBy"] != DBNull.Value ? Convert.ToString(dr["CTD_AssignBy"]) : CTDAssignBy = null;
		CTDDate = dr["CTD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["CTD_Date"]) : CTDDate = null;
		CTDStatus = dr["CTD_Status"] != DBNull.Value ? Convert.ToInt32(dr["CTD_Status"]) : CTDStatus = null;
	}
	
	public static TMSClassTeacherDetails[] MapFrom(DataSet ds)
	{
		List<TMSClassTeacherDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSClassTeacherDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ClassTeacherDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ClassTeacherDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSClassTeacherDetails instance = new TMSClassTeacherDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSClassTeacherDetails Get(System.Int64 ctdClassTeacherId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSClassTeacherDetails instance;
		
		
		instance = new TMSClassTeacherDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassTeacherDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ctdClassTeacherId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSClassTeacherDetails ID:" + ctdClassTeacherId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? ctdSchoolCatId, System.Int64? ctdSchoolSubCatId, System.Int64? ctdSubjectId, System.Int64? ctdFacultyId, System.String ctdAssignBy, System.DateTime? ctdDate, System.Int32? ctdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassTeacherDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ctdSchoolCatId, ctdSchoolSubCatId, ctdSubjectId, ctdFacultyId, ctdAssignBy, ctdDate, ctdStatus);
		
		if (transaction == null)
		this.CTDClassTeacherId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.CTDClassTeacherId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? ctdSchoolCatId, System.Int64? ctdSchoolSubCatId, System.Int64? ctdSubjectId, System.Int64? ctdFacultyId, System.String ctdAssignBy, System.DateTime? ctdDate, System.Int32? ctdStatus)
	{
		Insert(ctdSchoolCatId, ctdSchoolSubCatId, ctdSubjectId, ctdFacultyId, ctdAssignBy, ctdDate, ctdStatus, null);
	}
	/// <summary>
	/// Insert current TMSClassTeacherDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(CTDSchoolCatId, CTDSchoolSubCatId, CTDSubjectId, CTDFacultyId, CTDAssignBy, CTDDate, CTDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSClassTeacherDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ctdClassTeacherId, System.Int64? ctdSchoolCatId, System.Int64? ctdSchoolSubCatId, System.Int64? ctdSubjectId, System.Int64? ctdFacultyId, System.String ctdAssignBy, System.DateTime? ctdDate, System.Int32? ctdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassTeacherDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ctdClassTeacherId"].Value = ctdClassTeacherId;
		dbCommand.Parameters["@ctdSchoolCatId"].Value = ctdSchoolCatId;
		dbCommand.Parameters["@ctdSchoolSubCatId"].Value = ctdSchoolSubCatId;
		dbCommand.Parameters["@ctdSubjectId"].Value = ctdSubjectId;
		dbCommand.Parameters["@ctdFacultyId"].Value = ctdFacultyId;
		dbCommand.Parameters["@ctdAssignBy"].Value = ctdAssignBy;
		dbCommand.Parameters["@ctdDate"].Value = ctdDate;
		dbCommand.Parameters["@ctdStatus"].Value = ctdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ctdClassTeacherId, System.Int64? ctdSchoolCatId, System.Int64? ctdSchoolSubCatId, System.Int64? ctdSubjectId, System.Int64? ctdFacultyId, System.String ctdAssignBy, System.DateTime? ctdDate, System.Int32? ctdStatus)
	{
		Update(ctdClassTeacherId, ctdSchoolCatId, ctdSchoolSubCatId, ctdSubjectId, ctdFacultyId, ctdAssignBy, ctdDate, ctdStatus, null);
	}
	
	public static void Update(TMSClassTeacherDetails tMSClassTeacherDetails)
	{
		tMSClassTeacherDetails.Update();
	}
	
	public static void Update(TMSClassTeacherDetails tMSClassTeacherDetails, DbTransaction transaction)
	{
		tMSClassTeacherDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSClassTeacherDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ctdClassTeacherId"].SourceColumn = "CTD_ClassTeacherId";
		dbCommand.Parameters["@ctdSchoolCatId"].SourceColumn = "CTD_SchoolCatId";
		dbCommand.Parameters["@ctdSchoolSubCatId"].SourceColumn = "CTD_SchoolSubCatId";
		dbCommand.Parameters["@ctdSubjectId"].SourceColumn = "CTD_SubjectId";
		dbCommand.Parameters["@ctdFacultyId"].SourceColumn = "CTD_FacultyId";
		dbCommand.Parameters["@ctdAssignBy"].SourceColumn = "CTD_AssignBy";
		dbCommand.Parameters["@ctdDate"].SourceColumn = "CTD_Date";
		dbCommand.Parameters["@ctdStatus"].SourceColumn = "CTD_Status";
		
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
	public static void Delete(System.Int64? ctdClassTeacherId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassTeacherDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ctdClassTeacherId);
		
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
	public static void Delete(System.Int64? ctdClassTeacherId)
	{
		Delete(
		ctdClassTeacherId);
	}
	
	/// <summary>
	/// Delete current TMSClassTeacherDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassTeacherDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, CTDClassTeacherId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.CTDClassTeacherId = null;
	}
	
	/// <summary>
	/// Delete current TMSClassTeacherDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSClassTeacherDetails[] Search(System.Int64? ctdClassTeacherId, System.Int64? ctdSchoolCatId, System.Int64? ctdSchoolSubCatId, System.Int64? ctdSubjectId, System.Int64? ctdFacultyId, System.String ctdAssignBy, System.DateTime? ctdDate, System.Int32? ctdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSClassTeacherDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ctdClassTeacherId, ctdSchoolCatId, ctdSchoolSubCatId, ctdSubjectId, ctdFacultyId, ctdAssignBy, ctdDate, ctdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSClassTeacherDetails.MapFrom(ds);
	}
	
	
	public static TMSClassTeacherDetails[] Search(TMSClassTeacherDetails searchObject)
	{
		return Search ( searchObject.CTDClassTeacherId, searchObject.CTDSchoolCatId, searchObject.CTDSchoolSubCatId, searchObject.CTDSubjectId, searchObject.CTDFacultyId, searchObject.CTDAssignBy, searchObject.CTDDate, searchObject.CTDStatus);
	}
	
	/// <summary>
	/// Returns all TMSClassTeacherDetails objects.
	/// </summary>
	/// <returns>List of all TMSClassTeacherDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSClassTeacherDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

