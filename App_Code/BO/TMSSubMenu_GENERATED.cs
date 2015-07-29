/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/24/2012 2:53:46 PM                                    */
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
public partial class TMSSubMenu
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_SubMenu]";
	
	#endregion
	
	
	#region Fields
	private System.Int32? _subId;
	private System.Int32? _subParentId;
	private System.String _subContent;
	private System.String _subUrl;
	
	#endregion
	
	
	#region Properties
	public System.Int32? SubId
	{
		get
		{
			return _subId;
		}
		set
		{
			_subId = value;
		}
	}
	
	public System.Int32? SubParentId
	{
		get
		{
			return _subParentId;
		}
		set
		{
			_subParentId = value;
		}
	}
	
	public System.String SubContent
	{
		get
		{
			return _subContent;
		}
		set
		{
			_subContent = value;
		}
	}
	
	public System.String SubUrl
	{
		get
		{
			return _subUrl;
		}
		set
		{
			_subUrl = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("Sub_Id", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("Sub_ParentId", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("Sub_Content", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("Sub_Url", typeof(System.String) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SubId == null)
		dr["Sub_Id"] = DBNull.Value;
		else
		dr["Sub_Id"] = SubId;
		
		if (SubParentId == null)
		dr["Sub_ParentId"] = DBNull.Value;
		else
		dr["Sub_ParentId"] = SubParentId;
		
		if (SubContent == null)
		dr["Sub_Content"] = DBNull.Value;
		else
		dr["Sub_Content"] = SubContent;
		
		if (SubUrl == null)
		dr["Sub_Url"] = DBNull.Value;
		else
		dr["Sub_Url"] = SubUrl;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SubId = dr["Sub_Id"] != DBNull.Value ? Convert.ToInt32(dr["Sub_Id"]) : SubId = null;
		SubParentId = dr["Sub_ParentId"] != DBNull.Value ? Convert.ToInt32(dr["Sub_ParentId"]) : SubParentId = null;
		SubContent = dr["Sub_Content"] != DBNull.Value ? Convert.ToString(dr["Sub_Content"]) : SubContent = null;
		SubUrl = dr["Sub_Url"] != DBNull.Value ? Convert.ToString(dr["Sub_Url"]) : SubUrl = null;
	}
	
	public static TMSSubMenu[] MapFrom(DataSet ds)
	{
		List<TMSSubMenu> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSSubMenu>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_SubMenu] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_SubMenu] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSSubMenu instance = new TMSSubMenu();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSubMenu Get(System.Int32 subId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSSubMenu instance;
		
		
		instance = new TMSSubMenu();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubMenu_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, subId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSSubMenu ID:" + subId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int32? subParentId, System.String subContent, System.String subUrl, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubMenu_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, subParentId, subContent, subUrl);
		
		if (transaction == null)
		this.SubId = Convert.ToInt32(db.ExecuteScalar(dbCommand));
		else
		this.SubId = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int32? subParentId, System.String subContent, System.String subUrl)
	{
		Insert(subParentId, subContent, subUrl, null);
	}
	/// <summary>
	/// Insert current TMSSubMenu to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SubParentId, SubContent, SubUrl, transaction);
	}
	
	/// <summary>
	/// Insert current TMSSubMenu to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int32? subId, System.Int32? subParentId, System.String subContent, System.String subUrl, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubMenu_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@subId"].Value = subId;
		dbCommand.Parameters["@subParentId"].Value = subParentId;
		dbCommand.Parameters["@subContent"].Value = subContent;
		dbCommand.Parameters["@subUrl"].Value = subUrl;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int32? subId, System.Int32? subParentId, System.String subContent, System.String subUrl)
	{
		Update(subId, subParentId, subContent, subUrl, null);
	}
	
	public static void Update(TMSSubMenu tMSSubMenu)
	{
		tMSSubMenu.Update();
	}
	
	public static void Update(TMSSubMenu tMSSubMenu, DbTransaction transaction)
	{
		tMSSubMenu.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSSubMenu_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@subId"].SourceColumn = "Sub_Id";
		dbCommand.Parameters["@subParentId"].SourceColumn = "Sub_ParentId";
		dbCommand.Parameters["@subContent"].SourceColumn = "Sub_Content";
		dbCommand.Parameters["@subUrl"].SourceColumn = "Sub_Url";
		
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
	public static void Delete(System.Int32? subId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubMenu_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, subId);
		
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
	public static void Delete(System.Int32? subId)
	{
		Delete(
		subId);
	}
	
	/// <summary>
	/// Delete current TMSSubMenu from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubMenu_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SubId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SubId = null;
	}
	
	/// <summary>
	/// Delete current TMSSubMenu from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSubMenu[] Search(System.Int32? subId, System.Int32? subParentId, System.String subContent, System.String subUrl)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSubMenu_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, subId, subParentId, subContent, subUrl);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSSubMenu.MapFrom(ds);
	}
	
	
	public static TMSSubMenu[] Search(TMSSubMenu searchObject)
	{
		return Search ( searchObject.SubId, searchObject.SubParentId, searchObject.SubContent, searchObject.SubUrl);
	}
	
	/// <summary>
	/// Returns all TMSSubMenu objects.
	/// </summary>
	/// <returns>List of all TMSSubMenu objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSSubMenu[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

