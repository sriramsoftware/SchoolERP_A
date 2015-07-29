/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/23/2012 11:26:32 AM                                    */
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
public partial class TMSBlogDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_BlogDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _bdBlogId;
	private System.Int64? _bdParentLoginId;
	private System.Int64? _bdFacultyLoginId;
	private System.String _bdTitle;
	private System.String _bdDescription;
	private System.String _bdImage;
	private System.Int64? _bdReplyId;
	private System.DateTime? _bdDate;
	private System.Int32? _bdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? BDBlogId
	{
		get
		{
			return _bdBlogId;
		}
		set
		{
			_bdBlogId = value;
		}
	}
	
	public System.Int64? BDParentLoginId
	{
		get
		{
			return _bdParentLoginId;
		}
		set
		{
			_bdParentLoginId = value;
		}
	}
	
	public System.Int64? BDFacultyLoginId
	{
		get
		{
			return _bdFacultyLoginId;
		}
		set
		{
			_bdFacultyLoginId = value;
		}
	}
	
	public System.String BDTitle
	{
		get
		{
			return _bdTitle;
		}
		set
		{
			_bdTitle = value;
		}
	}
	
	public System.String BDDescription
	{
		get
		{
			return _bdDescription;
		}
		set
		{
			_bdDescription = value;
		}
	}
	
	public System.String BDImage
	{
		get
		{
			return _bdImage;
		}
		set
		{
			_bdImage = value;
		}
	}
	
	public System.Int64? BDReplyId
	{
		get
		{
			return _bdReplyId;
		}
		set
		{
			_bdReplyId = value;
		}
	}
	
	public System.DateTime? BDDate
	{
		get
		{
			return _bdDate;
		}
		set
		{
			_bdDate = value;
		}
	}
	
	public System.Int32? BDStatus
	{
		get
		{
			return _bdStatus;
		}
		set
		{
			_bdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("BD_BlogId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_ParentLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_FacultyLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Image", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_ReplyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("BD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (BDBlogId == null)
		dr["BD_BlogId"] = DBNull.Value;
		else
		dr["BD_BlogId"] = BDBlogId;
		
		if (BDParentLoginId == null)
		dr["BD_ParentLoginId"] = DBNull.Value;
		else
		dr["BD_ParentLoginId"] = BDParentLoginId;
		
		if (BDFacultyLoginId == null)
		dr["BD_FacultyLoginId"] = DBNull.Value;
		else
		dr["BD_FacultyLoginId"] = BDFacultyLoginId;
		
		if (BDTitle == null)
		dr["BD_Title"] = DBNull.Value;
		else
		dr["BD_Title"] = BDTitle;
		
		if (BDDescription == null)
		dr["BD_Description"] = DBNull.Value;
		else
		dr["BD_Description"] = BDDescription;
		
		if (BDImage == null)
		dr["BD_Image"] = DBNull.Value;
		else
		dr["BD_Image"] = BDImage;
		
		if (BDReplyId == null)
		dr["BD_ReplyId"] = DBNull.Value;
		else
		dr["BD_ReplyId"] = BDReplyId;
		
		if (BDDate == null)
		dr["BD_Date"] = DBNull.Value;
		else
		dr["BD_Date"] = BDDate;
		
		if (BDStatus == null)
		dr["BD_Status"] = DBNull.Value;
		else
		dr["BD_Status"] = BDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		BDBlogId = dr["BD_BlogId"] != DBNull.Value ? Convert.ToInt64(dr["BD_BlogId"]) : BDBlogId = null;
		BDParentLoginId = dr["BD_ParentLoginId"] != DBNull.Value ? Convert.ToInt64(dr["BD_ParentLoginId"]) : BDParentLoginId = null;
		BDFacultyLoginId = dr["BD_FacultyLoginId"] != DBNull.Value ? Convert.ToInt64(dr["BD_FacultyLoginId"]) : BDFacultyLoginId = null;
		BDTitle = dr["BD_Title"] != DBNull.Value ? Convert.ToString(dr["BD_Title"]) : BDTitle = null;
		BDDescription = dr["BD_Description"] != DBNull.Value ? Convert.ToString(dr["BD_Description"]) : BDDescription = null;
		BDImage = dr["BD_Image"] != DBNull.Value ? Convert.ToString(dr["BD_Image"]) : BDImage = null;
		BDReplyId = dr["BD_ReplyId"] != DBNull.Value ? Convert.ToInt64(dr["BD_ReplyId"]) : BDReplyId = null;
		BDDate = dr["BD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["BD_Date"]) : BDDate = null;
		BDStatus = dr["BD_Status"] != DBNull.Value ? Convert.ToInt32(dr["BD_Status"]) : BDStatus = null;
	}
	
	public static TMSBlogDetails[] MapFrom(DataSet ds)
	{
		List<TMSBlogDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSBlogDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_BlogDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_BlogDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSBlogDetails instance = new TMSBlogDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBlogDetails Get(System.Int64 bdBlogId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSBlogDetails instance;
		
		
		instance = new TMSBlogDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBlogDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bdBlogId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSBlogDetails ID:" + bdBlogId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? bdParentLoginId, System.Int64? bdFacultyLoginId, System.String bdTitle, System.String bdDescription, System.String bdImage, System.Int64? bdReplyId, System.DateTime? bdDate, System.Int32? bdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBlogDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bdParentLoginId, bdFacultyLoginId, bdTitle, bdDescription, bdImage, bdReplyId, bdDate, bdStatus);
		
		if (transaction == null)
		this.BDBlogId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.BDBlogId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? bdParentLoginId, System.Int64? bdFacultyLoginId, System.String bdTitle, System.String bdDescription, System.String bdImage, System.Int64? bdReplyId, System.DateTime? bdDate, System.Int32? bdStatus)
	{
		Insert(bdParentLoginId, bdFacultyLoginId, bdTitle, bdDescription, bdImage, bdReplyId, bdDate, bdStatus, null);
	}
	/// <summary>
	/// Insert current TMSBlogDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(BDParentLoginId, BDFacultyLoginId, BDTitle, BDDescription, BDImage, BDReplyId, BDDate, BDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSBlogDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? bdBlogId, System.Int64? bdParentLoginId, System.Int64? bdFacultyLoginId, System.String bdTitle, System.String bdDescription, System.String bdImage, System.Int64? bdReplyId, System.DateTime? bdDate, System.Int32? bdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBlogDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@bdBlogId"].Value = bdBlogId;
		dbCommand.Parameters["@bdParentLoginId"].Value = bdParentLoginId;
		dbCommand.Parameters["@bdFacultyLoginId"].Value = bdFacultyLoginId;
		dbCommand.Parameters["@bdTitle"].Value = bdTitle;
		dbCommand.Parameters["@bdDescription"].Value = bdDescription;
		dbCommand.Parameters["@bdImage"].Value = bdImage;
		dbCommand.Parameters["@bdReplyId"].Value = bdReplyId;
		dbCommand.Parameters["@bdDate"].Value = bdDate;
		dbCommand.Parameters["@bdStatus"].Value = bdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? bdBlogId, System.Int64? bdParentLoginId, System.Int64? bdFacultyLoginId, System.String bdTitle, System.String bdDescription, System.String bdImage, System.Int64? bdReplyId, System.DateTime? bdDate, System.Int32? bdStatus)
	{
		Update(bdBlogId, bdParentLoginId, bdFacultyLoginId, bdTitle, bdDescription, bdImage, bdReplyId, bdDate, bdStatus, null);
	}
	
	public static void Update(TMSBlogDetails tMSBlogDetails)
	{
		tMSBlogDetails.Update();
	}
	
	public static void Update(TMSBlogDetails tMSBlogDetails, DbTransaction transaction)
	{
		tMSBlogDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSBlogDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@bdBlogId"].SourceColumn = "BD_BlogId";
		dbCommand.Parameters["@bdParentLoginId"].SourceColumn = "BD_ParentLoginId";
		dbCommand.Parameters["@bdFacultyLoginId"].SourceColumn = "BD_FacultyLoginId";
		dbCommand.Parameters["@bdTitle"].SourceColumn = "BD_Title";
		dbCommand.Parameters["@bdDescription"].SourceColumn = "BD_Description";
		dbCommand.Parameters["@bdImage"].SourceColumn = "BD_Image";
		dbCommand.Parameters["@bdReplyId"].SourceColumn = "BD_ReplyId";
		dbCommand.Parameters["@bdDate"].SourceColumn = "BD_Date";
		dbCommand.Parameters["@bdStatus"].SourceColumn = "BD_Status";
		
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
	public static void Delete(System.Int64? bdBlogId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBlogDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bdBlogId);
		
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
	public static void Delete(System.Int64? bdBlogId)
	{
		Delete(
		bdBlogId);
	}
	
	/// <summary>
	/// Delete current TMSBlogDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBlogDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, BDBlogId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.BDBlogId = null;
	}
	
	/// <summary>
	/// Delete current TMSBlogDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSBlogDetails[] Search(System.Int64? bdBlogId, System.Int64? bdParentLoginId, System.Int64? bdFacultyLoginId, System.String bdTitle, System.String bdDescription, System.String bdImage, System.Int64? bdReplyId, System.DateTime? bdDate, System.Int32? bdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSBlogDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, bdBlogId, bdParentLoginId, bdFacultyLoginId, bdTitle, bdDescription, bdImage, bdReplyId, bdDate, bdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSBlogDetails.MapFrom(ds);
	}
	
	
	public static TMSBlogDetails[] Search(TMSBlogDetails searchObject)
	{
		return Search ( searchObject.BDBlogId, searchObject.BDParentLoginId, searchObject.BDFacultyLoginId, searchObject.BDTitle, searchObject.BDDescription, searchObject.BDImage, searchObject.BDReplyId, searchObject.BDDate, searchObject.BDStatus);
	}
	
	/// <summary>
	/// Returns all TMSBlogDetails objects.
	/// </summary>
	/// <returns>List of all TMSBlogDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSBlogDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

