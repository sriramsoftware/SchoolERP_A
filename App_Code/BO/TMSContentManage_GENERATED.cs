/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/25/2012 1:10:30 PM                                    */
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
public partial class TMSContentManage
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ContentManage]";
	
	#endregion
	
	
	#region Fields
	private System.Int32? _contentId;
	private System.String _contentName;
	private System.String _contentTitle;
	private System.String _contentDescription;
	private System.DateTime? _contentDate;
	
	#endregion
	
	
	#region Properties
	public System.Int32? ContentId
	{
		get
		{
			return _contentId;
		}
		set
		{
			_contentId = value;
		}
	}
	
	public System.String ContentName
	{
		get
		{
			return _contentName;
		}
		set
		{
			_contentName = value;
		}
	}
	
	public System.String ContentTitle
	{
		get
		{
			return _contentTitle;
		}
		set
		{
			_contentTitle = value;
		}
	}
	
	public System.String ContentDescription
	{
		get
		{
			return _contentDescription;
		}
		set
		{
			_contentDescription = value;
		}
	}
	
	public System.DateTime? ContentDate
	{
		get
		{
			return _contentDate;
		}
		set
		{
			_contentDate = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("Content_Id", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("Content_Name", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Content_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Content_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Content_Date", typeof(System.DateTime) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ContentId == null)
		dr["Content_Id"] = DBNull.Value;
		else
		dr["Content_Id"] = ContentId;
		
		if (ContentName == null)
		dr["Content_Name"] = DBNull.Value;
		else
		dr["Content_Name"] = ContentName;
		
		if (ContentTitle == null)
		dr["Content_Title"] = DBNull.Value;
		else
		dr["Content_Title"] = ContentTitle;
		
		if (ContentDescription == null)
		dr["Content_Description"] = DBNull.Value;
		else
		dr["Content_Description"] = ContentDescription;
		
		if (ContentDate == null)
		dr["Content_Date"] = DBNull.Value;
		else
		dr["Content_Date"] = ContentDate;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ContentId = dr["Content_Id"] != DBNull.Value ? Convert.ToInt32(dr["Content_Id"]) : ContentId = null;
		ContentName = dr["Content_Name"] != DBNull.Value ? Convert.ToString(dr["Content_Name"]) : ContentName = null;
		ContentTitle = dr["Content_Title"] != DBNull.Value ? Convert.ToString(dr["Content_Title"]) : ContentTitle = null;
		ContentDescription = dr["Content_Description"] != DBNull.Value ? Convert.ToString(dr["Content_Description"]) : ContentDescription = null;
		ContentDate = dr["Content_Date"] != DBNull.Value ? Convert.ToDateTime(dr["Content_Date"]) : ContentDate = null;
	}
	
	public static TMSContentManage[] MapFrom(DataSet ds)
	{
		List<TMSContentManage> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSContentManage>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ContentManage] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ContentManage] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSContentManage instance = new TMSContentManage();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSContentManage Get(System.Int32 contentId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSContentManage instance;
		
		
		instance = new TMSContentManage();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContentManage_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, contentId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSContentManage ID:" + contentId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String contentName, System.String contentTitle, System.String contentDescription, System.DateTime? contentDate, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContentManage_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, contentName, contentTitle, contentDescription, contentDate);
		
		if (transaction == null)
		this.ContentId = Convert.ToInt32(db.ExecuteScalar(dbCommand));
		else
		this.ContentId = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String contentName, System.String contentTitle, System.String contentDescription, System.DateTime? contentDate)
	{
		Insert(contentName, contentTitle, contentDescription, contentDate, null);
	}
	/// <summary>
	/// Insert current TMSContentManage to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ContentName, ContentTitle, ContentDescription, ContentDate, transaction);
	}
	
	/// <summary>
	/// Insert current TMSContentManage to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int32? contentId, System.String contentName, System.String contentTitle, System.String contentDescription, System.DateTime? contentDate, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContentManage_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@contentId"].Value = contentId;
		dbCommand.Parameters["@contentName"].Value = contentName;
		dbCommand.Parameters["@contentTitle"].Value = contentTitle;
		dbCommand.Parameters["@contentDescription"].Value = contentDescription;
		dbCommand.Parameters["@contentDate"].Value = contentDate;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int32? contentId, System.String contentName, System.String contentTitle, System.String contentDescription, System.DateTime? contentDate)
	{
		Update(contentId, contentName, contentTitle, contentDescription, contentDate, null);
	}
	
	public static void Update(TMSContentManage tMSContentManage)
	{
		tMSContentManage.Update();
	}
	
	public static void Update(TMSContentManage tMSContentManage, DbTransaction transaction)
	{
		tMSContentManage.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSContentManage_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@contentId"].SourceColumn = "Content_Id";
		dbCommand.Parameters["@contentName"].SourceColumn = "Content_Name";
		dbCommand.Parameters["@contentTitle"].SourceColumn = "Content_Title";
		dbCommand.Parameters["@contentDescription"].SourceColumn = "Content_Description";
		dbCommand.Parameters["@contentDate"].SourceColumn = "Content_Date";
		
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
	public static void Delete(System.Int32? contentId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContentManage_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, contentId);
		
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
	public static void Delete(System.Int32? contentId)
	{
		Delete(
		contentId);
	}
	
	/// <summary>
	/// Delete current TMSContentManage from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContentManage_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ContentId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ContentId = null;
	}
	
	/// <summary>
	/// Delete current TMSContentManage from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSContentManage[] Search(System.Int32? contentId, System.String contentName, System.String contentTitle, System.String contentDescription, System.DateTime? contentDate)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContentManage_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, contentId, contentName, contentTitle, contentDescription, contentDate);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSContentManage.MapFrom(ds);
	}
	
	
	public static TMSContentManage[] Search(TMSContentManage searchObject)
	{
		return Search ( searchObject.ContentId, searchObject.ContentName, searchObject.ContentTitle, searchObject.ContentDescription, searchObject.ContentDate);
	}
	
	/// <summary>
	/// Returns all TMSContentManage objects.
	/// </summary>
	/// <returns>List of all TMSContentManage objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSContentManage[] Search()
	{
		return Search ( null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

