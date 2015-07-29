/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/5/2012 5:24:55 PM                                    */
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
public partial class TMSUploadLectureDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_UploadLectureDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ulLectureId;
	private System.Int64? _ulFacultyId;
	private System.Int64? _ulFacultyLoginId;
	private System.Int64? _ulSchoolId;
	private System.Int64? _ulSchoolSubId;
	private System.String _ulTitle;
	private System.String _ulDescription;
	private System.String _ulVideoName;
	private System.String _ulThumbnailName;
	private System.String _ulExtra;
	private System.DateTime? _ulLectureDate;
	private System.DateTime? _ulDate;
	private System.Int32? _ulStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? ULLectureId
	{
		get
		{
			return _ulLectureId;
		}
		set
		{
			_ulLectureId = value;
		}
	}
	
	public System.Int64? ULFacultyId
	{
		get
		{
			return _ulFacultyId;
		}
		set
		{
			_ulFacultyId = value;
		}
	}
	
	public System.Int64? ULFacultyLoginId
	{
		get
		{
			return _ulFacultyLoginId;
		}
		set
		{
			_ulFacultyLoginId = value;
		}
	}
	
	public System.Int64? ULSchoolId
	{
		get
		{
			return _ulSchoolId;
		}
		set
		{
			_ulSchoolId = value;
		}
	}
	
	public System.Int64? ULSchoolSubId
	{
		get
		{
			return _ulSchoolSubId;
		}
		set
		{
			_ulSchoolSubId = value;
		}
	}
	
	public System.String ULTitle
	{
		get
		{
			return _ulTitle;
		}
		set
		{
			_ulTitle = value;
		}
	}
	
	public System.String ULDescription
	{
		get
		{
			return _ulDescription;
		}
		set
		{
			_ulDescription = value;
		}
	}
	
	public System.String ULVideoName
	{
		get
		{
			return _ulVideoName;
		}
		set
		{
			_ulVideoName = value;
		}
	}
	
	public System.String ULThumbnailName
	{
		get
		{
			return _ulThumbnailName;
		}
		set
		{
			_ulThumbnailName = value;
		}
	}
	
	public System.String ULExtra
	{
		get
		{
			return _ulExtra;
		}
		set
		{
			_ulExtra = value;
		}
	}
	
	public System.DateTime? ULLectureDate
	{
		get
		{
			return _ulLectureDate;
		}
		set
		{
			_ulLectureDate = value;
		}
	}
	
	public System.DateTime? ULDate
	{
		get
		{
			return _ulDate;
		}
		set
		{
			_ulDate = value;
		}
	}
	
	public System.Int32? ULStatus
	{
		get
		{
			return _ulStatus;
		}
		set
		{
			_ulStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("UL_LectureId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_FacultyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_FacultyLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_SchoolId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_SchoolSubId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_VideoName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_ThumbnailName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_Extra", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_LectureDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("UL_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ULLectureId == null)
		dr["UL_LectureId"] = DBNull.Value;
		else
		dr["UL_LectureId"] = ULLectureId;
		
		if (ULFacultyId == null)
		dr["UL_FacultyId"] = DBNull.Value;
		else
		dr["UL_FacultyId"] = ULFacultyId;
		
		if (ULFacultyLoginId == null)
		dr["UL_FacultyLoginId"] = DBNull.Value;
		else
		dr["UL_FacultyLoginId"] = ULFacultyLoginId;
		
		if (ULSchoolId == null)
		dr["UL_SchoolId"] = DBNull.Value;
		else
		dr["UL_SchoolId"] = ULSchoolId;
		
		if (ULSchoolSubId == null)
		dr["UL_SchoolSubId"] = DBNull.Value;
		else
		dr["UL_SchoolSubId"] = ULSchoolSubId;
		
		if (ULTitle == null)
		dr["UL_Title"] = DBNull.Value;
		else
		dr["UL_Title"] = ULTitle;
		
		if (ULDescription == null)
		dr["UL_Description"] = DBNull.Value;
		else
		dr["UL_Description"] = ULDescription;
		
		if (ULVideoName == null)
		dr["UL_VideoName"] = DBNull.Value;
		else
		dr["UL_VideoName"] = ULVideoName;
		
		if (ULThumbnailName == null)
		dr["UL_ThumbnailName"] = DBNull.Value;
		else
		dr["UL_ThumbnailName"] = ULThumbnailName;
		
		if (ULExtra == null)
		dr["UL_Extra"] = DBNull.Value;
		else
		dr["UL_Extra"] = ULExtra;
		
		if (ULLectureDate == null)
		dr["UL_LectureDate"] = DBNull.Value;
		else
		dr["UL_LectureDate"] = ULLectureDate;
		
		if (ULDate == null)
		dr["UL_Date"] = DBNull.Value;
		else
		dr["UL_Date"] = ULDate;
		
		if (ULStatus == null)
		dr["UL_Status"] = DBNull.Value;
		else
		dr["UL_Status"] = ULStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ULLectureId = dr["UL_LectureId"] != DBNull.Value ? Convert.ToInt64(dr["UL_LectureId"]) : ULLectureId = null;
		ULFacultyId = dr["UL_FacultyId"] != DBNull.Value ? Convert.ToInt64(dr["UL_FacultyId"]) : ULFacultyId = null;
		ULFacultyLoginId = dr["UL_FacultyLoginId"] != DBNull.Value ? Convert.ToInt64(dr["UL_FacultyLoginId"]) : ULFacultyLoginId = null;
		ULSchoolId = dr["UL_SchoolId"] != DBNull.Value ? Convert.ToInt64(dr["UL_SchoolId"]) : ULSchoolId = null;
		ULSchoolSubId = dr["UL_SchoolSubId"] != DBNull.Value ? Convert.ToInt64(dr["UL_SchoolSubId"]) : ULSchoolSubId = null;
		ULTitle = dr["UL_Title"] != DBNull.Value ? Convert.ToString(dr["UL_Title"]) : ULTitle = null;
		ULDescription = dr["UL_Description"] != DBNull.Value ? Convert.ToString(dr["UL_Description"]) : ULDescription = null;
		ULVideoName = dr["UL_VideoName"] != DBNull.Value ? Convert.ToString(dr["UL_VideoName"]) : ULVideoName = null;
		ULThumbnailName = dr["UL_ThumbnailName"] != DBNull.Value ? Convert.ToString(dr["UL_ThumbnailName"]) : ULThumbnailName = null;
		ULExtra = dr["UL_Extra"] != DBNull.Value ? Convert.ToString(dr["UL_Extra"]) : ULExtra = null;
		ULLectureDate = dr["UL_LectureDate"] != DBNull.Value ? Convert.ToDateTime(dr["UL_LectureDate"]) : ULLectureDate = null;
		ULDate = dr["UL_Date"] != DBNull.Value ? Convert.ToDateTime(dr["UL_Date"]) : ULDate = null;
		ULStatus = dr["UL_Status"] != DBNull.Value ? Convert.ToInt32(dr["UL_Status"]) : ULStatus = null;
	}
	
	public static TMSUploadLectureDetails[] MapFrom(DataSet ds)
	{
		List<TMSUploadLectureDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSUploadLectureDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_UploadLectureDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_UploadLectureDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSUploadLectureDetails instance = new TMSUploadLectureDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSUploadLectureDetails Get(System.Int64 ulLectureId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSUploadLectureDetails instance;
		
		
		instance = new TMSUploadLectureDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUploadLectureDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ulLectureId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSUploadLectureDetails ID:" + ulLectureId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? ulFacultyId, System.Int64? ulFacultyLoginId, System.Int64? ulSchoolId, System.Int64? ulSchoolSubId, System.String ulTitle, System.String ulDescription, System.String ulVideoName, System.String ulThumbnailName, System.String ulExtra, System.DateTime? ulLectureDate, System.DateTime? ulDate, System.Int32? ulStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUploadLectureDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ulFacultyId, ulFacultyLoginId, ulSchoolId, ulSchoolSubId, ulTitle, ulDescription, ulVideoName, ulThumbnailName, ulExtra, ulLectureDate, ulDate, ulStatus);
		
		if (transaction == null)
		this.ULLectureId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.ULLectureId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? ulFacultyId, System.Int64? ulFacultyLoginId, System.Int64? ulSchoolId, System.Int64? ulSchoolSubId, System.String ulTitle, System.String ulDescription, System.String ulVideoName, System.String ulThumbnailName, System.String ulExtra, System.DateTime? ulLectureDate, System.DateTime? ulDate, System.Int32? ulStatus)
	{
		Insert(ulFacultyId, ulFacultyLoginId, ulSchoolId, ulSchoolSubId, ulTitle, ulDescription, ulVideoName, ulThumbnailName, ulExtra, ulLectureDate, ulDate, ulStatus, null);
	}
	/// <summary>
	/// Insert current TMSUploadLectureDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ULFacultyId, ULFacultyLoginId, ULSchoolId, ULSchoolSubId, ULTitle, ULDescription, ULVideoName, ULThumbnailName, ULExtra, ULLectureDate, ULDate, ULStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSUploadLectureDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ulLectureId, System.Int64? ulFacultyId, System.Int64? ulFacultyLoginId, System.Int64? ulSchoolId, System.Int64? ulSchoolSubId, System.String ulTitle, System.String ulDescription, System.String ulVideoName, System.String ulThumbnailName, System.String ulExtra, System.DateTime? ulLectureDate, System.DateTime? ulDate, System.Int32? ulStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUploadLectureDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ulLectureId"].Value = ulLectureId;
		dbCommand.Parameters["@ulFacultyId"].Value = ulFacultyId;
		dbCommand.Parameters["@ulFacultyLoginId"].Value = ulFacultyLoginId;
		dbCommand.Parameters["@ulSchoolId"].Value = ulSchoolId;
		dbCommand.Parameters["@ulSchoolSubId"].Value = ulSchoolSubId;
		dbCommand.Parameters["@ulTitle"].Value = ulTitle;
		dbCommand.Parameters["@ulDescription"].Value = ulDescription;
		dbCommand.Parameters["@ulVideoName"].Value = ulVideoName;
		dbCommand.Parameters["@ulThumbnailName"].Value = ulThumbnailName;
		dbCommand.Parameters["@ulExtra"].Value = ulExtra;
		dbCommand.Parameters["@ulLectureDate"].Value = ulLectureDate;
		dbCommand.Parameters["@ulDate"].Value = ulDate;
		dbCommand.Parameters["@ulStatus"].Value = ulStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ulLectureId, System.Int64? ulFacultyId, System.Int64? ulFacultyLoginId, System.Int64? ulSchoolId, System.Int64? ulSchoolSubId, System.String ulTitle, System.String ulDescription, System.String ulVideoName, System.String ulThumbnailName, System.String ulExtra, System.DateTime? ulLectureDate, System.DateTime? ulDate, System.Int32? ulStatus)
	{
		Update(ulLectureId, ulFacultyId, ulFacultyLoginId, ulSchoolId, ulSchoolSubId, ulTitle, ulDescription, ulVideoName, ulThumbnailName, ulExtra, ulLectureDate, ulDate, ulStatus, null);
	}
	
	public static void Update(TMSUploadLectureDetails tMSUploadLectureDetails)
	{
		tMSUploadLectureDetails.Update();
	}
	
	public static void Update(TMSUploadLectureDetails tMSUploadLectureDetails, DbTransaction transaction)
	{
		tMSUploadLectureDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSUploadLectureDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ulLectureId"].SourceColumn = "UL_LectureId";
		dbCommand.Parameters["@ulFacultyId"].SourceColumn = "UL_FacultyId";
		dbCommand.Parameters["@ulFacultyLoginId"].SourceColumn = "UL_FacultyLoginId";
		dbCommand.Parameters["@ulSchoolId"].SourceColumn = "UL_SchoolId";
		dbCommand.Parameters["@ulSchoolSubId"].SourceColumn = "UL_SchoolSubId";
		dbCommand.Parameters["@ulTitle"].SourceColumn = "UL_Title";
		dbCommand.Parameters["@ulDescription"].SourceColumn = "UL_Description";
		dbCommand.Parameters["@ulVideoName"].SourceColumn = "UL_VideoName";
		dbCommand.Parameters["@ulThumbnailName"].SourceColumn = "UL_ThumbnailName";
		dbCommand.Parameters["@ulExtra"].SourceColumn = "UL_Extra";
		dbCommand.Parameters["@ulLectureDate"].SourceColumn = "UL_LectureDate";
		dbCommand.Parameters["@ulDate"].SourceColumn = "UL_Date";
		dbCommand.Parameters["@ulStatus"].SourceColumn = "UL_Status";
		
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
	public static void Delete(System.Int64? ulLectureId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUploadLectureDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ulLectureId);
		
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
	public static void Delete(System.Int64? ulLectureId)
	{
		Delete(
		ulLectureId);
	}
	
	/// <summary>
	/// Delete current TMSUploadLectureDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUploadLectureDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ULLectureId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ULLectureId = null;
	}
	
	/// <summary>
	/// Delete current TMSUploadLectureDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSUploadLectureDetails[] Search(System.Int64? ulLectureId, System.Int64? ulFacultyId, System.Int64? ulFacultyLoginId, System.Int64? ulSchoolId, System.Int64? ulSchoolSubId, System.String ulTitle, System.String ulDescription, System.String ulVideoName, System.String ulThumbnailName, System.String ulExtra, System.DateTime? ulLectureDate, System.DateTime? ulDate, System.Int32? ulStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSUploadLectureDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ulLectureId, ulFacultyId, ulFacultyLoginId, ulSchoolId, ulSchoolSubId, ulTitle, ulDescription, ulVideoName, ulThumbnailName, ulExtra, ulLectureDate, ulDate, ulStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSUploadLectureDetails.MapFrom(ds);
	}
	
	
	public static TMSUploadLectureDetails[] Search(TMSUploadLectureDetails searchObject)
	{
		return Search ( searchObject.ULLectureId, searchObject.ULFacultyId, searchObject.ULFacultyLoginId, searchObject.ULSchoolId, searchObject.ULSchoolSubId, searchObject.ULTitle, searchObject.ULDescription, searchObject.ULVideoName, searchObject.ULThumbnailName, searchObject.ULExtra, searchObject.ULLectureDate, searchObject.ULDate, searchObject.ULStatus);
	}
	
	/// <summary>
	/// Returns all TMSUploadLectureDetails objects.
	/// </summary>
	/// <returns>List of all TMSUploadLectureDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSUploadLectureDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

