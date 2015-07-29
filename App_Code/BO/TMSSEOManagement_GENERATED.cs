/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/22/2012 11:41:23 AM                                    */
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
public partial class TMSSEOManagement
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_SEOManagement]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _seoId;
	private System.String _seoPageName;
	private System.String _seoTitle;
	private System.String _seoKeywords;
	private System.String _seoDescription;
	private System.String _seoMetaType;
	private System.DateTime? _seoDate;
	private System.String _seoAddedyBy;
	private System.Int64? _seoAddedById;
	private System.Int32? _seoStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? SEOId
	{
		get
		{
			return _seoId;
		}
		set
		{
			_seoId = value;
		}
	}
	
	public System.String SEOPageName
	{
		get
		{
			return _seoPageName;
		}
		set
		{
			_seoPageName = value;
		}
	}
	
	public System.String SEOTitle
	{
		get
		{
			return _seoTitle;
		}
		set
		{
			_seoTitle = value;
		}
	}
	
	public System.String SEOKeywords
	{
		get
		{
			return _seoKeywords;
		}
		set
		{
			_seoKeywords = value;
		}
	}
	
	public System.String SEODescription
	{
		get
		{
			return _seoDescription;
		}
		set
		{
			_seoDescription = value;
		}
	}
	
	public System.String SEOMetaType
	{
		get
		{
			return _seoMetaType;
		}
		set
		{
			_seoMetaType = value;
		}
	}
	
	public System.DateTime? SEODate
	{
		get
		{
			return _seoDate;
		}
		set
		{
			_seoDate = value;
		}
	}
	
	public System.String SEOAddedyBy
	{
		get
		{
			return _seoAddedyBy;
		}
		set
		{
			_seoAddedyBy = value;
		}
	}
	
	public System.Int64? SEOAddedById
	{
		get
		{
			return _seoAddedById;
		}
		set
		{
			_seoAddedById = value;
		}
	}
	
	public System.Int32? SEOStatus
	{
		get
		{
			return _seoStatus;
		}
		set
		{
			_seoStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("SEO_Id", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SEO_PageName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SEO_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SEO_Keywords", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SEO_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SEO_MetaType", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SEO_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SEO_AddedyBy", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SEO_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SEO_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SEOId == null)
		dr["SEO_Id"] = DBNull.Value;
		else
		dr["SEO_Id"] = SEOId;
		
		if (SEOPageName == null)
		dr["SEO_PageName"] = DBNull.Value;
		else
		dr["SEO_PageName"] = SEOPageName;
		
		if (SEOTitle == null)
		dr["SEO_Title"] = DBNull.Value;
		else
		dr["SEO_Title"] = SEOTitle;
		
		if (SEOKeywords == null)
		dr["SEO_Keywords"] = DBNull.Value;
		else
		dr["SEO_Keywords"] = SEOKeywords;
		
		if (SEODescription == null)
		dr["SEO_Description"] = DBNull.Value;
		else
		dr["SEO_Description"] = SEODescription;
		
		if (SEOMetaType == null)
		dr["SEO_MetaType"] = DBNull.Value;
		else
		dr["SEO_MetaType"] = SEOMetaType;
		
		if (SEODate == null)
		dr["SEO_Date"] = DBNull.Value;
		else
		dr["SEO_Date"] = SEODate;
		
		if (SEOAddedyBy == null)
		dr["SEO_AddedyBy"] = DBNull.Value;
		else
		dr["SEO_AddedyBy"] = SEOAddedyBy;
		
		if (SEOAddedById == null)
		dr["SEO_AddedById"] = DBNull.Value;
		else
		dr["SEO_AddedById"] = SEOAddedById;
		
		if (SEOStatus == null)
		dr["SEO_Status"] = DBNull.Value;
		else
		dr["SEO_Status"] = SEOStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SEOId = dr["SEO_Id"] != DBNull.Value ? Convert.ToInt64(dr["SEO_Id"]) : SEOId = null;
		SEOPageName = dr["SEO_PageName"] != DBNull.Value ? Convert.ToString(dr["SEO_PageName"]) : SEOPageName = null;
		SEOTitle = dr["SEO_Title"] != DBNull.Value ? Convert.ToString(dr["SEO_Title"]) : SEOTitle = null;
		SEOKeywords = dr["SEO_Keywords"] != DBNull.Value ? Convert.ToString(dr["SEO_Keywords"]) : SEOKeywords = null;
		SEODescription = dr["SEO_Description"] != DBNull.Value ? Convert.ToString(dr["SEO_Description"]) : SEODescription = null;
		SEOMetaType = dr["SEO_MetaType"] != DBNull.Value ? Convert.ToString(dr["SEO_MetaType"]) : SEOMetaType = null;
		SEODate = dr["SEO_Date"] != DBNull.Value ? Convert.ToDateTime(dr["SEO_Date"]) : SEODate = null;
		SEOAddedyBy = dr["SEO_AddedyBy"] != DBNull.Value ? Convert.ToString(dr["SEO_AddedyBy"]) : SEOAddedyBy = null;
		SEOAddedById = dr["SEO_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["SEO_AddedById"]) : SEOAddedById = null;
		SEOStatus = dr["SEO_Status"] != DBNull.Value ? Convert.ToInt32(dr["SEO_Status"]) : SEOStatus = null;
	}
	
	public static TMSSEOManagement[] MapFrom(DataSet ds)
	{
		List<TMSSEOManagement> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSSEOManagement>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_SEOManagement] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_SEOManagement] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSSEOManagement instance = new TMSSEOManagement();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSEOManagement Get(System.Int64 seoId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSSEOManagement instance;
		
		
		instance = new TMSSEOManagement();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSEOManagement_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, seoId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSSEOManagement ID:" + seoId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String seoPageName, System.String seoTitle, System.String seoKeywords, System.String seoDescription, System.String seoMetaType, System.DateTime? seoDate, System.String seoAddedyBy, System.Int64? seoAddedById, System.Int32? seoStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSEOManagement_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, seoPageName, seoTitle, seoKeywords, seoDescription, seoMetaType, seoDate, seoAddedyBy, seoAddedById, seoStatus);
		
		if (transaction == null)
		this.SEOId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.SEOId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String seoPageName, System.String seoTitle, System.String seoKeywords, System.String seoDescription, System.String seoMetaType, System.DateTime? seoDate, System.String seoAddedyBy, System.Int64? seoAddedById, System.Int32? seoStatus)
	{
		Insert(seoPageName, seoTitle, seoKeywords, seoDescription, seoMetaType, seoDate, seoAddedyBy, seoAddedById, seoStatus, null);
	}
	/// <summary>
	/// Insert current TMSSEOManagement to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SEOPageName, SEOTitle, SEOKeywords, SEODescription, SEOMetaType, SEODate, SEOAddedyBy, SEOAddedById, SEOStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSSEOManagement to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? seoId, System.String seoPageName, System.String seoTitle, System.String seoKeywords, System.String seoDescription, System.String seoMetaType, System.DateTime? seoDate, System.String seoAddedyBy, System.Int64? seoAddedById, System.Int32? seoStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSEOManagement_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@seoId"].Value = seoId;
		dbCommand.Parameters["@seoPageName"].Value = seoPageName;
		dbCommand.Parameters["@seoTitle"].Value = seoTitle;
		dbCommand.Parameters["@seoKeywords"].Value = seoKeywords;
		dbCommand.Parameters["@seoDescription"].Value = seoDescription;
		dbCommand.Parameters["@seoMetaType"].Value = seoMetaType;
		dbCommand.Parameters["@seoDate"].Value = seoDate;
		dbCommand.Parameters["@seoAddedyBy"].Value = seoAddedyBy;
		dbCommand.Parameters["@seoAddedById"].Value = seoAddedById;
		dbCommand.Parameters["@seoStatus"].Value = seoStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? seoId, System.String seoPageName, System.String seoTitle, System.String seoKeywords, System.String seoDescription, System.String seoMetaType, System.DateTime? seoDate, System.String seoAddedyBy, System.Int64? seoAddedById, System.Int32? seoStatus)
	{
		Update(seoId, seoPageName, seoTitle, seoKeywords, seoDescription, seoMetaType, seoDate, seoAddedyBy, seoAddedById, seoStatus, null);
	}
	
	public static void Update(TMSSEOManagement tMSSEOManagement)
	{
		tMSSEOManagement.Update();
	}
	
	public static void Update(TMSSEOManagement tMSSEOManagement, DbTransaction transaction)
	{
		tMSSEOManagement.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSSEOManagement_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@seoId"].SourceColumn = "SEO_Id";
		dbCommand.Parameters["@seoPageName"].SourceColumn = "SEO_PageName";
		dbCommand.Parameters["@seoTitle"].SourceColumn = "SEO_Title";
		dbCommand.Parameters["@seoKeywords"].SourceColumn = "SEO_Keywords";
		dbCommand.Parameters["@seoDescription"].SourceColumn = "SEO_Description";
		dbCommand.Parameters["@seoMetaType"].SourceColumn = "SEO_MetaType";
		dbCommand.Parameters["@seoDate"].SourceColumn = "SEO_Date";
		dbCommand.Parameters["@seoAddedyBy"].SourceColumn = "SEO_AddedyBy";
		dbCommand.Parameters["@seoAddedById"].SourceColumn = "SEO_AddedById";
		dbCommand.Parameters["@seoStatus"].SourceColumn = "SEO_Status";
		
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
	public static void Delete(System.Int64? seoId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSEOManagement_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, seoId);
		
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
	public static void Delete(System.Int64? seoId)
	{
		Delete(
		seoId);
	}
	
	/// <summary>
	/// Delete current TMSSEOManagement from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSEOManagement_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SEOId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SEOId = null;
	}
	
	/// <summary>
	/// Delete current TMSSEOManagement from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSEOManagement[] Search(System.Int64? seoId, System.String seoPageName, System.String seoTitle, System.String seoKeywords, System.String seoDescription, System.String seoMetaType, System.DateTime? seoDate, System.String seoAddedyBy, System.Int64? seoAddedById, System.Int32? seoStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSEOManagement_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, seoId, seoPageName, seoTitle, seoKeywords, seoDescription, seoMetaType, seoDate, seoAddedyBy, seoAddedById, seoStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSSEOManagement.MapFrom(ds);
	}
	
	
	public static TMSSEOManagement[] Search(TMSSEOManagement searchObject)
	{
		return Search ( searchObject.SEOId, searchObject.SEOPageName, searchObject.SEOTitle, searchObject.SEOKeywords, searchObject.SEODescription, searchObject.SEOMetaType, searchObject.SEODate, searchObject.SEOAddedyBy, searchObject.SEOAddedById, searchObject.SEOStatus);
	}
	
	/// <summary>
	/// Returns all TMSSEOManagement objects.
	/// </summary>
	/// <returns>List of all TMSSEOManagement objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSSEOManagement[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

