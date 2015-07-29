/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/25/2012 6:26:04 PM                                    */
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
public partial class TMSNoteDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_NoteDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ndNoticeId;
	private System.Int64? _ndFacultyId;
	private System.Int64? _ndFacultyLoginId;
	private System.Int64? _ndSchoolId;
	private System.Int64? _ndSchoolSubId;
	private System.Int64? _ndSubjectId;
	private System.String _ndTitle;
	private System.String _ndNoticeDescription;
	private System.String _ndDescription;
	private System.DateTime? _ndSelectDate;
	private System.DateTime? _ndDate;
	private System.Int32? _ndStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? NDNoticeId
	{
		get
		{
			return _ndNoticeId;
		}
		set
		{
			_ndNoticeId = value;
		}
	}
	
	public System.Int64? NDFacultyId
	{
		get
		{
			return _ndFacultyId;
		}
		set
		{
			_ndFacultyId = value;
		}
	}
	
	public System.Int64? NDFacultyLoginId
	{
		get
		{
			return _ndFacultyLoginId;
		}
		set
		{
			_ndFacultyLoginId = value;
		}
	}
	
	public System.Int64? NDSchoolId
	{
		get
		{
			return _ndSchoolId;
		}
		set
		{
			_ndSchoolId = value;
		}
	}
	
	public System.Int64? NDSchoolSubId
	{
		get
		{
			return _ndSchoolSubId;
		}
		set
		{
			_ndSchoolSubId = value;
		}
	}
	
	public System.Int64? NDSubjectId
	{
		get
		{
			return _ndSubjectId;
		}
		set
		{
			_ndSubjectId = value;
		}
	}
	
	public System.String NDTitle
	{
		get
		{
			return _ndTitle;
		}
		set
		{
			_ndTitle = value;
		}
	}
	
	public System.String NDNoticeDescription
	{
		get
		{
			return _ndNoticeDescription;
		}
		set
		{
			_ndNoticeDescription = value;
		}
	}
	
	public System.String NDDescription
	{
		get
		{
			return _ndDescription;
		}
		set
		{
			_ndDescription = value;
		}
	}
	
	public System.DateTime? NDSelectDate
	{
		get
		{
			return _ndSelectDate;
		}
		set
		{
			_ndSelectDate = value;
		}
	}
	
	public System.DateTime? NDDate
	{
		get
		{
			return _ndDate;
		}
		set
		{
			_ndDate = value;
		}
	}
	
	public System.Int32? NDStatus
	{
		get
		{
			return _ndStatus;
		}
		set
		{
			_ndStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("ND_NoticeId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_FacultyLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_NoticeDescription", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_SelectDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (NDNoticeId == null)
		dr["ND_NoticeId"] = DBNull.Value;
		else
		dr["ND_NoticeId"] = NDNoticeId;
		
		if (NDFacultyId == null)
		dr["ND_FacultyId"] = DBNull.Value;
		else
		dr["ND_FacultyId"] = NDFacultyId;
		
		if (NDFacultyLoginId == null)
		dr["ND_FacultyLoginId"] = DBNull.Value;
		else
		dr["ND_FacultyLoginId"] = NDFacultyLoginId;
		
		if (NDSchoolId == null)
		dr["ND_SchoolId"] = DBNull.Value;
		else
		dr["ND_SchoolId"] = NDSchoolId;
		
		if (NDSchoolSubId == null)
		dr["ND_SchoolSubId"] = DBNull.Value;
		else
		dr["ND_SchoolSubId"] = NDSchoolSubId;
		
		if (NDSubjectId == null)
		dr["ND_SubjectId"] = DBNull.Value;
		else
		dr["ND_SubjectId"] = NDSubjectId;
		
		if (NDTitle == null)
		dr["ND_Title"] = DBNull.Value;
		else
		dr["ND_Title"] = NDTitle;
		
		if (NDNoticeDescription == null)
		dr["ND_NoticeDescription"] = DBNull.Value;
		else
		dr["ND_NoticeDescription"] = NDNoticeDescription;
		
		if (NDDescription == null)
		dr["ND_Description"] = DBNull.Value;
		else
		dr["ND_Description"] = NDDescription;
		
		if (NDSelectDate == null)
		dr["ND_SelectDate"] = DBNull.Value;
		else
		dr["ND_SelectDate"] = NDSelectDate;
		
		if (NDDate == null)
		dr["ND_Date"] = DBNull.Value;
		else
		dr["ND_Date"] = NDDate;
		
		if (NDStatus == null)
		dr["ND_Status"] = DBNull.Value;
		else
		dr["ND_Status"] = NDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		NDNoticeId = dr["ND_NoticeId"] != DBNull.Value ? Convert.ToInt64(dr["ND_NoticeId"]) : NDNoticeId = null;
		NDFacultyId = dr["ND_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["ND_FacultyId"]) : NDFacultyId = null;
		NDFacultyLoginId = dr["ND_FacultyLoginId"] != DBNull.Value ? Convert.ToInt64(dr["ND_FacultyLoginId"]) : NDFacultyLoginId = null;
		NDSchoolId = dr["ND_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["ND_SchoolId"]) : NDSchoolId = null;
		NDSchoolSubId = dr["ND_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["ND_SchoolSubId"]) : NDSchoolSubId = null;
		NDSubjectId = dr["ND_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["ND_SubjectId"]) : NDSubjectId = null;
		NDTitle = dr["ND_Title"] != DBNull.Value ? Convert.ToString(dr["ND_Title"]) : NDTitle = null;
		NDNoticeDescription = dr["ND_NoticeDescription"] != DBNull.Value ? Convert.ToString(dr["ND_NoticeDescription"]) : NDNoticeDescription = null;
		NDDescription = dr["ND_Description"] != DBNull.Value ? Convert.ToString(dr["ND_Description"]) : NDDescription = null;
		NDSelectDate = dr["ND_SelectDate"] != DBNull.Value ? Convert.ToDateTime(dr["ND_SelectDate"]) : NDSelectDate = null;
		NDDate = dr["ND_Date"] != DBNull.Value ? Convert.ToDateTime(dr["ND_Date"]) : NDDate = null;
		NDStatus = dr["ND_Status"] != DBNull.Value ? Convert.ToInt32(dr["ND_Status"]) : NDStatus = null;
	}
	
	public static TMSNoteDetails[] MapFrom(DataSet ds)
	{
		List<TMSNoteDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSNoteDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_NoteDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_NoteDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSNoteDetails instance = new TMSNoteDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSNoteDetails Get(System.Int64 ndNoticeId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSNoteDetails instance;
		
		
		instance = new TMSNoteDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNoteDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ndNoticeId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSNoteDetails ID:" + ndNoticeId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? ndFacultyId, System.Int64? ndFacultyLoginId, System.Int64? ndSchoolId, System.Int64? ndSchoolSubId, System.Int64? ndSubjectId, System.String ndTitle, System.String ndNoticeDescription, System.String ndDescription, System.DateTime? ndSelectDate, System.DateTime? ndDate, System.Int32? ndStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNoteDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ndFacultyId, ndFacultyLoginId, ndSchoolId, ndSchoolSubId, ndSubjectId, ndTitle, ndNoticeDescription, ndDescription, ndSelectDate, ndDate, ndStatus);
		
		if (transaction == null)
		this.NDNoticeId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.NDNoticeId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? ndFacultyId, System.Int64? ndFacultyLoginId, System.Int64? ndSchoolId, System.Int64? ndSchoolSubId, System.Int64? ndSubjectId, System.String ndTitle, System.String ndNoticeDescription, System.String ndDescription, System.DateTime? ndSelectDate, System.DateTime? ndDate, System.Int32? ndStatus)
	{
		Insert(ndFacultyId, ndFacultyLoginId, ndSchoolId, ndSchoolSubId, ndSubjectId, ndTitle, ndNoticeDescription, ndDescription, ndSelectDate, ndDate, ndStatus, null);
	}
	/// <summary>
	/// Insert current TMSNoteDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(NDFacultyId, NDFacultyLoginId, NDSchoolId, NDSchoolSubId, NDSubjectId, NDTitle, NDNoticeDescription, NDDescription, NDSelectDate, NDDate, NDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSNoteDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ndNoticeId, System.Int64? ndFacultyId, System.Int64? ndFacultyLoginId, System.Int64? ndSchoolId, System.Int64? ndSchoolSubId, System.Int64? ndSubjectId, System.String ndTitle, System.String ndNoticeDescription, System.String ndDescription, System.DateTime? ndSelectDate, System.DateTime? ndDate, System.Int32? ndStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNoteDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ndNoticeId"].Value = ndNoticeId;
		dbCommand.Parameters["@ndFacultyId"].Value = ndFacultyId;
		dbCommand.Parameters["@ndFacultyLoginId"].Value = ndFacultyLoginId;
		dbCommand.Parameters["@ndSchoolId"].Value = ndSchoolId;
		dbCommand.Parameters["@ndSchoolSubId"].Value = ndSchoolSubId;
		dbCommand.Parameters["@ndSubjectId"].Value = ndSubjectId;
		dbCommand.Parameters["@ndTitle"].Value = ndTitle;
		dbCommand.Parameters["@ndNoticeDescription"].Value = ndNoticeDescription;
		dbCommand.Parameters["@ndDescription"].Value = ndDescription;
		dbCommand.Parameters["@ndSelectDate"].Value = ndSelectDate;
		dbCommand.Parameters["@ndDate"].Value = ndDate;
		dbCommand.Parameters["@ndStatus"].Value = ndStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ndNoticeId, System.Int64? ndFacultyId, System.Int64? ndFacultyLoginId, System.Int64? ndSchoolId, System.Int64? ndSchoolSubId, System.Int64? ndSubjectId, System.String ndTitle, System.String ndNoticeDescription, System.String ndDescription, System.DateTime? ndSelectDate, System.DateTime? ndDate, System.Int32? ndStatus)
	{
		Update(ndNoticeId, ndFacultyId, ndFacultyLoginId, ndSchoolId, ndSchoolSubId, ndSubjectId, ndTitle, ndNoticeDescription, ndDescription, ndSelectDate, ndDate, ndStatus, null);
	}
	
	public static void Update(TMSNoteDetails tMSNoteDetails)
	{
		tMSNoteDetails.Update();
	}
	
	public static void Update(TMSNoteDetails tMSNoteDetails, DbTransaction transaction)
	{
		tMSNoteDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSNoteDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ndNoticeId"].SourceColumn = "ND_NoticeId";
		dbCommand.Parameters["@ndFacultyId"].SourceColumn = "ND_FacultyId";
		dbCommand.Parameters["@ndFacultyLoginId"].SourceColumn = "ND_FacultyLoginId";
		dbCommand.Parameters["@ndSchoolId"].SourceColumn = "ND_SchoolId";
		dbCommand.Parameters["@ndSchoolSubId"].SourceColumn = "ND_SchoolSubId";
		dbCommand.Parameters["@ndSubjectId"].SourceColumn = "ND_SubjectId";
		dbCommand.Parameters["@ndTitle"].SourceColumn = "ND_Title";
		dbCommand.Parameters["@ndNoticeDescription"].SourceColumn = "ND_NoticeDescription";
		dbCommand.Parameters["@ndDescription"].SourceColumn = "ND_Description";
		dbCommand.Parameters["@ndSelectDate"].SourceColumn = "ND_SelectDate";
		dbCommand.Parameters["@ndDate"].SourceColumn = "ND_Date";
		dbCommand.Parameters["@ndStatus"].SourceColumn = "ND_Status";
		
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
	public static void Delete(System.Int64? ndNoticeId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNoteDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ndNoticeId);
		
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
	public static void Delete(System.Int64? ndNoticeId)
	{
		Delete(
		ndNoticeId);
	}
	
	/// <summary>
	/// Delete current TMSNoteDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNoteDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, NDNoticeId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.NDNoticeId = null;
	}
	
	/// <summary>
	/// Delete current TMSNoteDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSNoteDetails[] Search(System.Int64? ndNoticeId, System.Int64? ndFacultyId, System.Int64? ndFacultyLoginId, System.Int64? ndSchoolId, System.Int64? ndSchoolSubId, System.Int64? ndSubjectId, System.String ndTitle, System.String ndNoticeDescription, System.String ndDescription, System.DateTime? ndSelectDate, System.DateTime? ndDate, System.Int32? ndStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNoteDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ndNoticeId, ndFacultyId, ndFacultyLoginId, ndSchoolId, ndSchoolSubId, ndSubjectId, ndTitle, ndNoticeDescription, ndDescription, ndSelectDate, ndDate, ndStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSNoteDetails.MapFrom(ds);
	}
	
	
	public static TMSNoteDetails[] Search(TMSNoteDetails searchObject)
	{
		return Search ( searchObject.NDNoticeId, searchObject.NDFacultyId, searchObject.NDFacultyLoginId, searchObject.NDSchoolId, searchObject.NDSchoolSubId, searchObject.NDSubjectId, searchObject.NDTitle, searchObject.NDNoticeDescription, searchObject.NDDescription, searchObject.NDSelectDate, searchObject.NDDate, searchObject.NDStatus);
	}
	
	/// <summary>
	/// Returns all TMSNoteDetails objects.
	/// </summary>
	/// <returns>List of all TMSNoteDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSNoteDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

