/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/25/2012 11:32:38 AM                                    */
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
public partial class TMSNews
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_News]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _nwId;
	private System.String _ndHeading;
	private System.String _ndImagePath;
	private System.String _ndDescription;
	private System.DateTime? _ndCreatedDate;
	private System.Int32? _ndStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? NwId
	{
		get
		{
			return _nwId;
		}
		set
		{
			_nwId = value;
		}
	}
	
	public System.String NDHeading
	{
		get
		{
			return _ndHeading;
		}
		set
		{
			_ndHeading = value;
		}
	}
	
	public System.String NDImagePath
	{
		get
		{
			return _ndImagePath;
		}
		set
		{
			_ndImagePath = value;
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
	
	public System.DateTime? NDCreatedDate
	{
		get
		{
			return _ndCreatedDate;
		}
		set
		{
			_ndCreatedDate = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("NW_ID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_Heading", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_ImagePath", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_CreatedDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("ND_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (NwId == null)
		dr["NW_ID"] = DBNull.Value;
		else
		dr["NW_ID"] = NwId;
		
		if (NDHeading == null)
		dr["ND_Heading"] = DBNull.Value;
		else
		dr["ND_Heading"] = NDHeading;
		
		if (NDImagePath == null)
		dr["ND_ImagePath"] = DBNull.Value;
		else
		dr["ND_ImagePath"] = NDImagePath;
		
		if (NDDescription == null)
		dr["ND_Description"] = DBNull.Value;
		else
		dr["ND_Description"] = NDDescription;
		
		if (NDCreatedDate == null)
		dr["ND_CreatedDate"] = DBNull.Value;
		else
		dr["ND_CreatedDate"] = NDCreatedDate;
		
		if (NDStatus == null)
		dr["ND_Status"] = DBNull.Value;
		else
		dr["ND_Status"] = NDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		NwId = dr["NW_ID"] != DBNull.Value ? Convert.ToInt64(dr["NW_ID"]) : NwId = null;
		NDHeading = dr["ND_Heading"] != DBNull.Value ? Convert.ToString(dr["ND_Heading"]) : NDHeading = null;
		NDImagePath = dr["ND_ImagePath"] != DBNull.Value ? Convert.ToString(dr["ND_ImagePath"]) : NDImagePath = null;
		NDDescription = dr["ND_Description"] != DBNull.Value ? Convert.ToString(dr["ND_Description"]) : NDDescription = null;
		NDCreatedDate = dr["ND_CreatedDate"] != DBNull.Value ? Convert.ToDateTime(dr["ND_CreatedDate"]) : NDCreatedDate = null;
		NDStatus = dr["ND_Status"] != DBNull.Value ? Convert.ToInt32(dr["ND_Status"]) : NDStatus = null;
	}
	
	public static TMSNews[] MapFrom(DataSet ds)
	{
		List<TMSNews> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSNews>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_News] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_News] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSNews instance = new TMSNews();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSNews Get(System.Int64 nwId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSNews instance;
		
		
		instance = new TMSNews();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNews_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, nwId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSNews ID:" + nwId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String ndHeading, System.String ndImagePath, System.String ndDescription, System.DateTime? ndCreatedDate, System.Int32? ndStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNews_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ndHeading, ndImagePath, ndDescription, ndCreatedDate, ndStatus);
		
		if (transaction == null)
		this.NwId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.NwId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String ndHeading, System.String ndImagePath, System.String ndDescription, System.DateTime? ndCreatedDate, System.Int32? ndStatus)
	{
		Insert(ndHeading, ndImagePath, ndDescription, ndCreatedDate, ndStatus, null);
	}
	/// <summary>
	/// Insert current TMSNews to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(NDHeading, NDImagePath, NDDescription, NDCreatedDate, NDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSNews to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? nwId, System.String ndHeading, System.String ndImagePath, System.String ndDescription, System.DateTime? ndCreatedDate, System.Int32? ndStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNews_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@nwId"].Value = nwId;
		dbCommand.Parameters["@ndHeading"].Value = ndHeading;
		dbCommand.Parameters["@ndImagePath"].Value = ndImagePath;
		dbCommand.Parameters["@ndDescription"].Value = ndDescription;
		dbCommand.Parameters["@ndCreatedDate"].Value = ndCreatedDate;
		dbCommand.Parameters["@ndStatus"].Value = ndStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? nwId, System.String ndHeading, System.String ndImagePath, System.String ndDescription, System.DateTime? ndCreatedDate, System.Int32? ndStatus)
	{
		Update(nwId, ndHeading, ndImagePath, ndDescription, ndCreatedDate, ndStatus, null);
	}
	
	public static void Update(TMSNews tMSNews)
	{
		tMSNews.Update();
	}
	
	public static void Update(TMSNews tMSNews, DbTransaction transaction)
	{
		tMSNews.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSNews_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@nwId"].SourceColumn = "NW_ID";
		dbCommand.Parameters["@ndHeading"].SourceColumn = "ND_Heading";
		dbCommand.Parameters["@ndImagePath"].SourceColumn = "ND_ImagePath";
		dbCommand.Parameters["@ndDescription"].SourceColumn = "ND_Description";
		dbCommand.Parameters["@ndCreatedDate"].SourceColumn = "ND_CreatedDate";
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
	public static void Delete(System.Int64? nwId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNews_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, nwId);
		
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
	public static void Delete(System.Int64? nwId)
	{
		Delete(
		nwId);
	}
	
	/// <summary>
	/// Delete current TMSNews from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNews_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, NwId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.NwId = null;
	}
	
	/// <summary>
	/// Delete current TMSNews from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSNews[] Search(System.Int64? nwId, System.String ndHeading, System.String ndImagePath, System.String ndDescription, System.DateTime? ndCreatedDate, System.Int32? ndStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSNews_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, nwId, ndHeading, ndImagePath, ndDescription, ndCreatedDate, ndStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSNews.MapFrom(ds);
	}
	
	
	public static TMSNews[] Search(TMSNews searchObject)
	{
		return Search ( searchObject.NwId, searchObject.NDHeading, searchObject.NDImagePath, searchObject.NDDescription, searchObject.NDCreatedDate, searchObject.NDStatus);
	}
	
	/// <summary>
	/// Returns all TMSNews objects.
	/// </summary>
	/// <returns>List of all TMSNews objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSNews[] Search()
	{
		return Search ( null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

