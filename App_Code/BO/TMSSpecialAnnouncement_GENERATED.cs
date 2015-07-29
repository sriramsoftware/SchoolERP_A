/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/20/2012 6:52:52 PM                                    */
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
public partial class TMSSpecialAnnouncement
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_SpecialAnnouncement]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _saAnnoucementId;
	private System.String _saTitle;
	private System.String _saDescription;
	private System.String _saDescription1;
	private System.Int64? _saReplyId;
	private System.DateTime? _saDate;
	private System.Int32? _saStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? SAAnnoucementId
	{
		get
		{
			return _saAnnoucementId;
		}
		set
		{
			_saAnnoucementId = value;
		}
	}
	
	public System.String SATitle
	{
		get
		{
			return _saTitle;
		}
		set
		{
			_saTitle = value;
		}
	}
	
	public System.String SADescription
	{
		get
		{
			return _saDescription;
		}
		set
		{
			_saDescription = value;
		}
	}
	
	public System.String SADescription1
	{
		get
		{
			return _saDescription1;
		}
		set
		{
			_saDescription1 = value;
		}
	}
	
	public System.Int64? SAReplyId
	{
		get
		{
			return _saReplyId;
		}
		set
		{
			_saReplyId = value;
		}
	}
	
	public System.DateTime? SADate
	{
		get
		{
			return _saDate;
		}
		set
		{
			_saDate = value;
		}
	}
	
	public System.Int32? SAStatus
	{
		get
		{
			return _saStatus;
		}
		set
		{
			_saStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("SA_AnnoucementId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_Description1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_ReplyId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SA_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SAAnnoucementId == null)
		dr["SA_AnnoucementId"] = DBNull.Value;
		else
		dr["SA_AnnoucementId"] = SAAnnoucementId;
		
		if (SATitle == null)
		dr["SA_Title"] = DBNull.Value;
		else
		dr["SA_Title"] = SATitle;
		
		if (SADescription == null)
		dr["SA_Description"] = DBNull.Value;
		else
		dr["SA_Description"] = SADescription;
		
		if (SADescription1 == null)
		dr["SA_Description1"] = DBNull.Value;
		else
		dr["SA_Description1"] = SADescription1;
		
		if (SAReplyId == null)
		dr["SA_ReplyId"] = DBNull.Value;
		else
		dr["SA_ReplyId"] = SAReplyId;
		
		if (SADate == null)
		dr["SA_Date"] = DBNull.Value;
		else
		dr["SA_Date"] = SADate;
		
		if (SAStatus == null)
		dr["SA_Status"] = DBNull.Value;
		else
		dr["SA_Status"] = SAStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SAAnnoucementId = dr["SA_AnnoucementId"] != DBNull.Value ? Convert.ToInt64(dr["SA_AnnoucementId"]) : SAAnnoucementId = null;
		SATitle = dr["SA_Title"] != DBNull.Value ? Convert.ToString(dr["SA_Title"]) : SATitle = null;
		SADescription = dr["SA_Description"] != DBNull.Value ? Convert.ToString(dr["SA_Description"]) : SADescription = null;
		SADescription1 = dr["SA_Description1"] != DBNull.Value ? Convert.ToString(dr["SA_Description1"]) : SADescription1 = null;
		SAReplyId = dr["SA_ReplyId"] != DBNull.Value ? Convert.ToInt64(dr["SA_ReplyId"]) : SAReplyId = null;
		SADate = dr["SA_Date"] != DBNull.Value ? Convert.ToDateTime(dr["SA_Date"]) : SADate = null;
		SAStatus = dr["SA_Status"] != DBNull.Value ? Convert.ToInt32(dr["SA_Status"]) : SAStatus = null;
	}
	
	public static TMSSpecialAnnouncement[] MapFrom(DataSet ds)
	{
		List<TMSSpecialAnnouncement> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSSpecialAnnouncement>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_SpecialAnnouncement] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_SpecialAnnouncement] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSSpecialAnnouncement instance = new TMSSpecialAnnouncement();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSpecialAnnouncement Get(System.Int64 saAnnoucementId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSSpecialAnnouncement instance;
		
		
		instance = new TMSSpecialAnnouncement();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSpecialAnnouncement_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, saAnnoucementId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSSpecialAnnouncement ID:" + saAnnoucementId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String saTitle, System.String saDescription, System.String saDescription1, System.Int64? saReplyId, System.DateTime? saDate, System.Int32? saStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSpecialAnnouncement_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, saTitle, saDescription, saDescription1, saReplyId, saDate, saStatus);
		
		if (transaction == null)
		this.SAAnnoucementId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.SAAnnoucementId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String saTitle, System.String saDescription, System.String saDescription1, System.Int64? saReplyId, System.DateTime? saDate, System.Int32? saStatus)
	{
		Insert(saTitle, saDescription, saDescription1, saReplyId, saDate, saStatus, null);
	}
	/// <summary>
	/// Insert current TMSSpecialAnnouncement to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SATitle, SADescription, SADescription1, SAReplyId, SADate, SAStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSSpecialAnnouncement to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? saAnnoucementId, System.String saTitle, System.String saDescription, System.String saDescription1, System.Int64? saReplyId, System.DateTime? saDate, System.Int32? saStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSpecialAnnouncement_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@saAnnoucementId"].Value = saAnnoucementId;
		dbCommand.Parameters["@saTitle"].Value = saTitle;
		dbCommand.Parameters["@saDescription"].Value = saDescription;
		dbCommand.Parameters["@saDescription1"].Value = saDescription1;
		dbCommand.Parameters["@saReplyId"].Value = saReplyId;
		dbCommand.Parameters["@saDate"].Value = saDate;
		dbCommand.Parameters["@saStatus"].Value = saStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? saAnnoucementId, System.String saTitle, System.String saDescription, System.String saDescription1, System.Int64? saReplyId, System.DateTime? saDate, System.Int32? saStatus)
	{
		Update(saAnnoucementId, saTitle, saDescription, saDescription1, saReplyId, saDate, saStatus, null);
	}
	
	public static void Update(TMSSpecialAnnouncement tMSSpecialAnnouncement)
	{
		tMSSpecialAnnouncement.Update();
	}
	
	public static void Update(TMSSpecialAnnouncement tMSSpecialAnnouncement, DbTransaction transaction)
	{
		tMSSpecialAnnouncement.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSSpecialAnnouncement_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@saAnnoucementId"].SourceColumn = "SA_AnnoucementId";
		dbCommand.Parameters["@saTitle"].SourceColumn = "SA_Title";
		dbCommand.Parameters["@saDescription"].SourceColumn = "SA_Description";
		dbCommand.Parameters["@saDescription1"].SourceColumn = "SA_Description1";
		dbCommand.Parameters["@saReplyId"].SourceColumn = "SA_ReplyId";
		dbCommand.Parameters["@saDate"].SourceColumn = "SA_Date";
		dbCommand.Parameters["@saStatus"].SourceColumn = "SA_Status";
		
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
	public static void Delete(System.Int64? saAnnoucementId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSpecialAnnouncement_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, saAnnoucementId);
		
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
	public static void Delete(System.Int64? saAnnoucementId)
	{
		Delete(
		saAnnoucementId);
	}
	
	/// <summary>
	/// Delete current TMSSpecialAnnouncement from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSpecialAnnouncement_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SAAnnoucementId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SAAnnoucementId = null;
	}
	
	/// <summary>
	/// Delete current TMSSpecialAnnouncement from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSSpecialAnnouncement[] Search(System.Int64? saAnnoucementId, System.String saTitle, System.String saDescription, System.String saDescription1, System.Int64? saReplyId, System.DateTime? saDate, System.Int32? saStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSSpecialAnnouncement_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, saAnnoucementId, saTitle, saDescription, saDescription1, saReplyId, saDate, saStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSSpecialAnnouncement.MapFrom(ds);
	}
	
	
	public static TMSSpecialAnnouncement[] Search(TMSSpecialAnnouncement searchObject)
	{
		return Search ( searchObject.SAAnnoucementId, searchObject.SATitle, searchObject.SADescription, searchObject.SADescription1, searchObject.SAReplyId, searchObject.SADate, searchObject.SAStatus);
	}
	
	/// <summary>
	/// Returns all TMSSpecialAnnouncement objects.
	/// </summary>
	/// <returns>List of all TMSSpecialAnnouncement objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSSpecialAnnouncement[] Search()
	{
		return Search ( null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

