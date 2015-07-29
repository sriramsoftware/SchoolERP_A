/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 9/6/2012 11:00:08 AM                                    */
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
public partial class TMSSyllabusDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_SyllabusDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _sdSyllabusId;
	private System.Int64? _sdUnitTestId;
	private System.Int64? _sdSchoolCatId;
	private System.Int64? _sdSubSchoolCatId;
	private System.Int64? _sdSubjectId;
	private System.String _sdTitle;
	private System.String _sdDescription;
	private System.String _sdDesription1;
	private System.DateTime? _sdDate;
	private System.String _sdAddedBy;
	private System.Int64? _sdAddedByID;
	private System.Int32? _sdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? SDSyllabusId
	{
		get
		{
			return _sdSyllabusId;
		}
		set
		{
			_sdSyllabusId = value;
		}
	}
	
	public System.Int64? SDUnitTestId
	{
		get
		{
			return _sdUnitTestId;
		}
		set
		{
			_sdUnitTestId = value;
		}
	}
	
	public System.Int64? SDSchoolCatId
	{
		get
		{
			return _sdSchoolCatId;
		}
		set
		{
			_sdSchoolCatId = value;
		}
	}
	
	public System.Int64? SDSubSchoolCatId
	{
		get
		{
			return _sdSubSchoolCatId;
		}
		set
		{
			_sdSubSchoolCatId = value;
		}
	}
	
	public System.Int64? SDSubjectId
	{
		get
		{
			return _sdSubjectId;
		}
		set
		{
			_sdSubjectId = value;
		}
	}
	
	public System.String SDTitle
	{
		get
		{
			return _sdTitle;
		}
		set
		{
			_sdTitle = value;
		}
	}
	
	public System.String SDDescription
	{
		get
		{
			return _sdDescription;
		}
		set
		{
			_sdDescription = value;
		}
	}
	
	public System.String SDDesription1
	{
		get
		{
			return _sdDesription1;
		}
		set
		{
			_sdDesription1 = value;
		}
	}
	
	public System.DateTime? SDDate
	{
		get
		{
			return _sdDate;
		}
		set
		{
			_sdDate = value;
		}
	}
	
	public System.String SDAddedBy
	{
		get
		{
			return _sdAddedBy;
		}
		set
		{
			_sdAddedBy = value;
		}
	}
	
	public System.Int64? SDAddedByID
	{
		get
		{
			return _sdAddedByID;
		}
		set
		{
			_sdAddedByID = value;
		}
	}
	
	public System.Int32? SDStatus
	{
		get
		{
			return _sdStatus;
		}
		set
		{
			_sdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("SD_SyllabusId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_UnitTestId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_SchoolCatId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_SubSchoolCatId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_SubjectId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_Desription1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_AddedBy", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_AddedByID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SDSyllabusId == null)
		dr["SD_SyllabusId"] = DBNull.Value;
		else
		dr["SD_SyllabusId"] = SDSyllabusId;
		
		if (SDUnitTestId == null)
		dr["SD_UnitTestId"] = DBNull.Value;
		else
		dr["SD_UnitTestId"] = SDUnitTestId;
		
		if (SDSchoolCatId == null)
		dr["SD_SchoolCatId"] = DBNull.Value;
		else
		dr["SD_SchoolCatId"] = SDSchoolCatId;
		
		if (SDSubSchoolCatId == null)
		dr["SD_SubSchoolCatId"] = DBNull.Value;
		else
		dr["SD_SubSchoolCatId"] = SDSubSchoolCatId;
		
		if (SDSubjectId == null)
		dr["SD_SubjectId"] = DBNull.Value;
		else
		dr["SD_SubjectId"] = SDSubjectId;
		
		if (SDTitle == null)
		dr["SD_Title"] = DBNull.Value;
		else
		dr["SD_Title"] = SDTitle;
		
		if (SDDescription == null)
		dr["SD_Description"] = DBNull.Value;
		else
		dr["SD_Description"] = SDDescription;
		
		if (SDDesription1 == null)
		dr["SD_Desription1"] = DBNull.Value;
		else
		dr["SD_Desription1"] = SDDesription1;
		
		if (SDDate == null)
		dr["SD_Date"] = DBNull.Value;
		else
		dr["SD_Date"] = SDDate;
		
		if (SDAddedBy == null)
		dr["SD_AddedBy"] = DBNull.Value;
		else
		dr["SD_AddedBy"] = SDAddedBy;
		
		if (SDAddedByID == null)
		dr["SD_AddedByID"] = DBNull.Value;
		else
		dr["SD_AddedByID"] = SDAddedByID;
		
		if (SDStatus == null)
		dr["SD_Status"] = DBNull.Value;
		else
		dr["SD_Status"] = SDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SDSyllabusId = dr["SD_SyllabusId"] != DBNull.Value ? Convert.ToInt64(dr["SD_SyllabusId"]) : SDSyllabusId = null;
		SDUnitTestId = dr["SD_UnitTestId"] != DBNull.Value ? Convert.ToInt64(dr["SD_UnitTestId"]) : SDUnitTestId = null;
		SDSchoolCatId = dr["SD_SchoolCatId"] != DBNull.Value ? Convert.ToInt64(dr["SD_SchoolCatId"]) : SDSchoolCatId = null;
		SDSubSchoolCatId = dr["SD_SubSchoolCatId"] != DBNull.Value ? Convert.ToInt64(dr["SD_SubSchoolCatId"]) : SDSubSchoolCatId = null;
		SDSubjectId = dr["SD_SubjectId"] != DBNull.Value ? Convert.ToInt64(dr["SD_SubjectId"]) : SDSubjectId = null;
		SDTitle = dr["SD_Title"] != DBNull.Value ? Convert.ToString(dr["SD_Title"]) : SDTitle = null;
		SDDescription = dr["SD_Description"] != DBNull.Value ? Convert.ToString(dr["SD_Description"]) : SDDescription = null;
		SDDesription1 = dr["SD_Desription1"] != DBNull.Value ? Convert.ToString(dr["SD_Desription1"]) : SDDesription1 = null;
		SDDate = dr["SD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["SD_Date"]) : SDDate = null;
		SDAddedBy = dr["SD_AddedBy"] != DBNull.Value ? Convert.ToString(dr["SD_AddedBy"]) : SDAddedBy = null;
		SDAddedByID = dr["SD_AddedByID"] != DBNull.Value ? Convert.ToInt64(dr["SD_AddedByID"]) : SDAddedByID = null;
		SDStatus = dr["SD_Status"] != DBNull.Value ? Convert.ToInt32(dr["SD_Status"]) : SDStatus = null;
	}
	
	public static TMSSyllabusDetails[] MapFrom(DataSet ds)
	{
		List<TMSSyllabusDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSSyllabusDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_SyllabusDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_SyllabusDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSSyllabusDetails instance = new TMSSyllabusDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSyllabusDetails Get(System.Int64 sdSyllabusId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSSyllabusDetails instance;
		
		
		instance = new TMSSyllabusDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSyllabusDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sdSyllabusId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSSyllabusDetails ID:" + sdSyllabusId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? sdUnitTestId, System.Int64? sdSchoolCatId, System.Int64? sdSubSchoolCatId, System.Int64? sdSubjectId, System.String sdTitle, System.String sdDescription, System.String sdDesription1, System.DateTime? sdDate, System.String sdAddedBy, System.Int64? sdAddedByID, System.Int32? sdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSyllabusDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sdUnitTestId, sdSchoolCatId, sdSubSchoolCatId, sdSubjectId, sdTitle, sdDescription, sdDesription1, sdDate, sdAddedBy, sdAddedByID, sdStatus);
		
		if (transaction == null)
		this.SDSyllabusId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.SDSyllabusId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? sdUnitTestId, System.Int64? sdSchoolCatId, System.Int64? sdSubSchoolCatId, System.Int64? sdSubjectId, System.String sdTitle, System.String sdDescription, System.String sdDesription1, System.DateTime? sdDate, System.String sdAddedBy, System.Int64? sdAddedByID, System.Int32? sdStatus)
	{
		Insert(sdUnitTestId, sdSchoolCatId, sdSubSchoolCatId, sdSubjectId, sdTitle, sdDescription, sdDesription1, sdDate, sdAddedBy, sdAddedByID, sdStatus, null);
	}
	/// <summary>
	/// Insert current TMSSyllabusDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SDUnitTestId, SDSchoolCatId, SDSubSchoolCatId, SDSubjectId, SDTitle, SDDescription, SDDesription1, SDDate, SDAddedBy, SDAddedByID, SDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSSyllabusDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? sdSyllabusId, System.Int64? sdUnitTestId, System.Int64? sdSchoolCatId, System.Int64? sdSubSchoolCatId, System.Int64? sdSubjectId, System.String sdTitle, System.String sdDescription, System.String sdDesription1, System.DateTime? sdDate, System.String sdAddedBy, System.Int64? sdAddedByID, System.Int32? sdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSyllabusDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sdSyllabusId"].Value = sdSyllabusId;
		dbCommand.Parameters["@sdUnitTestId"].Value = sdUnitTestId;
		dbCommand.Parameters["@sdSchoolCatId"].Value = sdSchoolCatId;
		dbCommand.Parameters["@sdSubSchoolCatId"].Value = sdSubSchoolCatId;
		dbCommand.Parameters["@sdSubjectId"].Value = sdSubjectId;
		dbCommand.Parameters["@sdTitle"].Value = sdTitle;
		dbCommand.Parameters["@sdDescription"].Value = sdDescription;
		dbCommand.Parameters["@sdDesription1"].Value = sdDesription1;
		dbCommand.Parameters["@sdDate"].Value = sdDate;
		dbCommand.Parameters["@sdAddedBy"].Value = sdAddedBy;
		dbCommand.Parameters["@sdAddedByID"].Value = sdAddedByID;
		dbCommand.Parameters["@sdStatus"].Value = sdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? sdSyllabusId, System.Int64? sdUnitTestId, System.Int64? sdSchoolCatId, System.Int64? sdSubSchoolCatId, System.Int64? sdSubjectId, System.String sdTitle, System.String sdDescription, System.String sdDesription1, System.DateTime? sdDate, System.String sdAddedBy, System.Int64? sdAddedByID, System.Int32? sdStatus)
	{
		Update(sdSyllabusId, sdUnitTestId, sdSchoolCatId, sdSubSchoolCatId, sdSubjectId, sdTitle, sdDescription, sdDesription1, sdDate, sdAddedBy, sdAddedByID, sdStatus, null);
	}
	
	public static void Update(TMSSyllabusDetails tMSSyllabusDetails)
	{
		tMSSyllabusDetails.Update();
	}
	
	public static void Update(TMSSyllabusDetails tMSSyllabusDetails, DbTransaction transaction)
	{
		tMSSyllabusDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSSyllabusDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sdSyllabusId"].SourceColumn = "SD_SyllabusId";
		dbCommand.Parameters["@sdUnitTestId"].SourceColumn = "SD_UnitTestId";
		dbCommand.Parameters["@sdSchoolCatId"].SourceColumn = "SD_SchoolCatId";
		dbCommand.Parameters["@sdSubSchoolCatId"].SourceColumn = "SD_SubSchoolCatId";
		dbCommand.Parameters["@sdSubjectId"].SourceColumn = "SD_SubjectId";
		dbCommand.Parameters["@sdTitle"].SourceColumn = "SD_Title";
		dbCommand.Parameters["@sdDescription"].SourceColumn = "SD_Description";
		dbCommand.Parameters["@sdDesription1"].SourceColumn = "SD_Desription1";
		dbCommand.Parameters["@sdDate"].SourceColumn = "SD_Date";
		dbCommand.Parameters["@sdAddedBy"].SourceColumn = "SD_AddedBy";
		dbCommand.Parameters["@sdAddedByID"].SourceColumn = "SD_AddedByID";
		dbCommand.Parameters["@sdStatus"].SourceColumn = "SD_Status";
		
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
	public static void Delete(System.Int64? sdSyllabusId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSyllabusDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sdSyllabusId);
		
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
	public static void Delete(System.Int64? sdSyllabusId)
	{
		Delete(
		sdSyllabusId);
	}
	
	/// <summary>
	/// Delete current TMSSyllabusDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSyllabusDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SDSyllabusId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SDSyllabusId = null;
	}
	
	/// <summary>
	/// Delete current TMSSyllabusDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSyllabusDetails[] Search(System.Int64? sdSyllabusId, System.Int64? sdUnitTestId, System.Int64? sdSchoolCatId, System.Int64? sdSubSchoolCatId, System.Int64? sdSubjectId, System.String sdTitle, System.String sdDescription, System.String sdDesription1, System.DateTime? sdDate, System.String sdAddedBy, System.Int64? sdAddedByID, System.Int32? sdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSyllabusDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sdSyllabusId, sdUnitTestId, sdSchoolCatId, sdSubSchoolCatId, sdSubjectId, sdTitle, sdDescription, sdDesription1, sdDate, sdAddedBy, sdAddedByID, sdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSSyllabusDetails.MapFrom(ds);
	}
	
	
	public static TMSSyllabusDetails[] Search(TMSSyllabusDetails searchObject)
	{
		return Search ( searchObject.SDSyllabusId, searchObject.SDUnitTestId, searchObject.SDSchoolCatId, searchObject.SDSubSchoolCatId, searchObject.SDSubjectId, searchObject.SDTitle, searchObject.SDDescription, searchObject.SDDesription1, searchObject.SDDate, searchObject.SDAddedBy, searchObject.SDAddedByID, searchObject.SDStatus);
	}
	
	/// <summary>
	/// Returns all TMSSyllabusDetails objects.
	/// </summary>
	/// <returns>List of all TMSSyllabusDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSSyllabusDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

