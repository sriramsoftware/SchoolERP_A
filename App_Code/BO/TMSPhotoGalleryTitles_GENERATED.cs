/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/25/2012 4:07:17 PM                                    */
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
public partial class TMSPhotoGalleryTitles
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_PhotoGalleryTitles]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _glId;
	private System.String _glTitle;
	private System.String _glImagePath;
	private System.DateTime? _glEventDate;
	private System.Int32? _glStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? GlId
	{
		get
		{
			return _glId;
		}
		set
		{
			_glId = value;
		}
	}
	
	public System.String GLTitle
	{
		get
		{
			return _glTitle;
		}
		set
		{
			_glTitle = value;
		}
	}
	
	public System.String GLImagePath
	{
		get
		{
			return _glImagePath;
		}
		set
		{
			_glImagePath = value;
		}
	}
	
	public System.DateTime? GLEventDate
	{
		get
		{
			return _glEventDate;
		}
		set
		{
			_glEventDate = value;
		}
	}
	
	public System.Int32? GLStatus
	{
		get
		{
			return _glStatus;
		}
		set
		{
			_glStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("GL_ID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("GL_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("GL_ImagePath", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("GL_EventDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("GL_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (GlId == null)
		dr["GL_ID"] = DBNull.Value;
		else
		dr["GL_ID"] = GlId;
		
		if (GLTitle == null)
		dr["GL_Title"] = DBNull.Value;
		else
		dr["GL_Title"] = GLTitle;
		
		if (GLImagePath == null)
		dr["GL_ImagePath"] = DBNull.Value;
		else
		dr["GL_ImagePath"] = GLImagePath;
		
		if (GLEventDate == null)
		dr["GL_EventDate"] = DBNull.Value;
		else
		dr["GL_EventDate"] = GLEventDate;
		
		if (GLStatus == null)
		dr["GL_Status"] = DBNull.Value;
		else
		dr["GL_Status"] = GLStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		GlId = dr["GL_ID"] != DBNull.Value ? Convert.ToInt64(dr["GL_ID"]) : GlId = null;
		GLTitle = dr["GL_Title"] != DBNull.Value ? Convert.ToString(dr["GL_Title"]) : GLTitle = null;
		GLImagePath = dr["GL_ImagePath"] != DBNull.Value ? Convert.ToString(dr["GL_ImagePath"]) : GLImagePath = null;
		GLEventDate = dr["GL_EventDate"] != DBNull.Value ? Convert.ToDateTime(dr["GL_EventDate"]) : GLEventDate = null;
		GLStatus = dr["GL_Status"] != DBNull.Value ? Convert.ToInt32(dr["GL_Status"]) : GLStatus = null;
	}
	
	public static TMSPhotoGalleryTitles[] MapFrom(DataSet ds)
	{
		List<TMSPhotoGalleryTitles> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSPhotoGalleryTitles>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_PhotoGalleryTitles] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_PhotoGalleryTitles] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSPhotoGalleryTitles instance = new TMSPhotoGalleryTitles();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSPhotoGalleryTitles Get(System.Int64 glId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSPhotoGalleryTitles instance;
		
		
		instance = new TMSPhotoGalleryTitles();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPhotoGalleryTitles_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, glId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSPhotoGalleryTitles ID:" + glId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String glTitle, System.String glImagePath, System.DateTime? glEventDate, System.Int32? glStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPhotoGalleryTitles_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, glTitle, glImagePath, glEventDate, glStatus);
		
		if (transaction == null)
		this.GlId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.GlId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String glTitle, System.String glImagePath, System.DateTime? glEventDate, System.Int32? glStatus)
	{
		Insert(glTitle, glImagePath, glEventDate, glStatus, null);
	}
	/// <summary>
	/// Insert current TMSPhotoGalleryTitles to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(GLTitle, GLImagePath, GLEventDate, GLStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSPhotoGalleryTitles to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? glId, System.String glTitle, System.String glImagePath, System.DateTime? glEventDate, System.Int32? glStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPhotoGalleryTitles_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@glId"].Value = glId;
		dbCommand.Parameters["@glTitle"].Value = glTitle;
		dbCommand.Parameters["@glImagePath"].Value = glImagePath;
		dbCommand.Parameters["@glEventDate"].Value = glEventDate;
		dbCommand.Parameters["@glStatus"].Value = glStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? glId, System.String glTitle, System.String glImagePath, System.DateTime? glEventDate, System.Int32? glStatus)
	{
		Update(glId, glTitle, glImagePath, glEventDate, glStatus, null);
	}
	
	public static void Update(TMSPhotoGalleryTitles tMSPhotoGalleryTitles)
	{
		tMSPhotoGalleryTitles.Update();
	}
	
	public static void Update(TMSPhotoGalleryTitles tMSPhotoGalleryTitles, DbTransaction transaction)
	{
		tMSPhotoGalleryTitles.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSPhotoGalleryTitles_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@glId"].SourceColumn = "GL_ID";
		dbCommand.Parameters["@glTitle"].SourceColumn = "GL_Title";
		dbCommand.Parameters["@glImagePath"].SourceColumn = "GL_ImagePath";
		dbCommand.Parameters["@glEventDate"].SourceColumn = "GL_EventDate";
		dbCommand.Parameters["@glStatus"].SourceColumn = "GL_Status";
		
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
	public static void Delete(System.Int64? glId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPhotoGalleryTitles_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, glId);
		
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
	public static void Delete(System.Int64? glId)
	{
		Delete(
		glId);
	}
	
	/// <summary>
	/// Delete current TMSPhotoGalleryTitles from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPhotoGalleryTitles_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, GlId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.GlId = null;
	}
	
	/// <summary>
	/// Delete current TMSPhotoGalleryTitles from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSPhotoGalleryTitles[] Search(System.Int64? glId, System.String glTitle, System.String glImagePath, System.DateTime? glEventDate, System.Int32? glStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPhotoGalleryTitles_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, glId, glTitle, glImagePath, glEventDate, glStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSPhotoGalleryTitles.MapFrom(ds);
	}
	
	
	public static TMSPhotoGalleryTitles[] Search(TMSPhotoGalleryTitles searchObject)
	{
		return Search ( searchObject.GlId, searchObject.GLTitle, searchObject.GLImagePath, searchObject.GLEventDate, searchObject.GLStatus);
	}
	
	/// <summary>
	/// Returns all TMSPhotoGalleryTitles objects.
	/// </summary>
	/// <returns>List of all TMSPhotoGalleryTitles objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSPhotoGalleryTitles[] Search()
	{
		return Search ( null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

