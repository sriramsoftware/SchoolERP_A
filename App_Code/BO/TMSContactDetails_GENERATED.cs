/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/7/2012 2:32:39 PM                                    */
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
public partial class TMSContactDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ContactDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _cdDetailsId;
	private System.String _cdTitle;
	private System.String _cdName;
	private System.String _cdMobile;
	private System.String _cdEmailId;
	private System.String _cdmsnId;
	private System.String _cdgTalkId;
	private System.String _cdSkype;
	private System.String _cdWebsite;
	private System.String _cdExtra1;
	private System.String _cdExtra2;
	private System.DateTime? _cdDate;
	private System.Int32? _cdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? CDDetailsId
	{
		get
		{
			return _cdDetailsId;
		}
		set
		{
			_cdDetailsId = value;
		}
	}
	
	public System.String CDTitle
	{
		get
		{
			return _cdTitle;
		}
		set
		{
			_cdTitle = value;
		}
	}
	
	public System.String CDName
	{
		get
		{
			return _cdName;
		}
		set
		{
			_cdName = value;
		}
	}
	
	public System.String CDMobile
	{
		get
		{
			return _cdMobile;
		}
		set
		{
			_cdMobile = value;
		}
	}
	
	public System.String CDEmailId
	{
		get
		{
			return _cdEmailId;
		}
		set
		{
			_cdEmailId = value;
		}
	}
	
	public System.String CDMSNId
	{
		get
		{
			return _cdmsnId;
		}
		set
		{
			_cdmsnId = value;
		}
	}
	
	public System.String CDGTalkId
	{
		get
		{
			return _cdgTalkId;
		}
		set
		{
			_cdgTalkId = value;
		}
	}
	
	public System.String CDSkype
	{
		get
		{
			return _cdSkype;
		}
		set
		{
			_cdSkype = value;
		}
	}
	
	public System.String CDWebsite
	{
		get
		{
			return _cdWebsite;
		}
		set
		{
			_cdWebsite = value;
		}
	}
	
	public System.String CDExtra1
	{
		get
		{
			return _cdExtra1;
		}
		set
		{
			_cdExtra1 = value;
		}
	}
	
	public System.String CDExtra2
	{
		get
		{
			return _cdExtra2;
		}
		set
		{
			_cdExtra2 = value;
		}
	}
	
	public System.DateTime? CDDate
	{
		get
		{
			return _cdDate;
		}
		set
		{
			_cdDate = value;
		}
	}
	
	public System.Int32? CDStatus
	{
		get
		{
			return _cdStatus;
		}
		set
		{
			_cdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("CD_DetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_Name", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_Mobile", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_EmailId", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_MSNId", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_GTalkId", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_Skype", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_Website", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_Extra1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_Extra2", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("CD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (CDDetailsId == null)
		dr["CD_DetailsId"] = DBNull.Value;
		else
		dr["CD_DetailsId"] = CDDetailsId;
		
		if (CDTitle == null)
		dr["CD_Title"] = DBNull.Value;
		else
		dr["CD_Title"] = CDTitle;
		
		if (CDName == null)
		dr["CD_Name"] = DBNull.Value;
		else
		dr["CD_Name"] = CDName;
		
		if (CDMobile == null)
		dr["CD_Mobile"] = DBNull.Value;
		else
		dr["CD_Mobile"] = CDMobile;
		
		if (CDEmailId == null)
		dr["CD_EmailId"] = DBNull.Value;
		else
		dr["CD_EmailId"] = CDEmailId;
		
		if (CDMSNId == null)
		dr["CD_MSNId"] = DBNull.Value;
		else
		dr["CD_MSNId"] = CDMSNId;
		
		if (CDGTalkId == null)
		dr["CD_GTalkId"] = DBNull.Value;
		else
		dr["CD_GTalkId"] = CDGTalkId;
		
		if (CDSkype == null)
		dr["CD_Skype"] = DBNull.Value;
		else
		dr["CD_Skype"] = CDSkype;
		
		if (CDWebsite == null)
		dr["CD_Website"] = DBNull.Value;
		else
		dr["CD_Website"] = CDWebsite;
		
		if (CDExtra1 == null)
		dr["CD_Extra1"] = DBNull.Value;
		else
		dr["CD_Extra1"] = CDExtra1;
		
		if (CDExtra2 == null)
		dr["CD_Extra2"] = DBNull.Value;
		else
		dr["CD_Extra2"] = CDExtra2;
		
		if (CDDate == null)
		dr["CD_Date"] = DBNull.Value;
		else
		dr["CD_Date"] = CDDate;
		
		if (CDStatus == null)
		dr["CD_Status"] = DBNull.Value;
		else
		dr["CD_Status"] = CDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		CDDetailsId = dr["CD_DetailsId"] != DBNull.Value ? Convert.ToInt64(dr["CD_DetailsId"]) : CDDetailsId = null;
		CDTitle = dr["CD_Title"] != DBNull.Value ? Convert.ToString(dr["CD_Title"]) : CDTitle = null;
		CDName = dr["CD_Name"] != DBNull.Value ? Convert.ToString(dr["CD_Name"]) : CDName = null;
		CDMobile = dr["CD_Mobile"] != DBNull.Value ? Convert.ToString(dr["CD_Mobile"]) : CDMobile = null;
		CDEmailId = dr["CD_EmailId"] != DBNull.Value ? Convert.ToString(dr["CD_EmailId"]) : CDEmailId = null;
		CDMSNId = dr["CD_MSNId"] != DBNull.Value ? Convert.ToString(dr["CD_MSNId"]) : CDMSNId = null;
		CDGTalkId = dr["CD_GTalkId"] != DBNull.Value ? Convert.ToString(dr["CD_GTalkId"]) : CDGTalkId = null;
		CDSkype = dr["CD_Skype"] != DBNull.Value ? Convert.ToString(dr["CD_Skype"]) : CDSkype = null;
		CDWebsite = dr["CD_Website"] != DBNull.Value ? Convert.ToString(dr["CD_Website"]) : CDWebsite = null;
		CDExtra1 = dr["CD_Extra1"] != DBNull.Value ? Convert.ToString(dr["CD_Extra1"]) : CDExtra1 = null;
		CDExtra2 = dr["CD_Extra2"] != DBNull.Value ? Convert.ToString(dr["CD_Extra2"]) : CDExtra2 = null;
		CDDate = dr["CD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["CD_Date"]) : CDDate = null;
		CDStatus = dr["CD_Status"] != DBNull.Value ? Convert.ToInt32(dr["CD_Status"]) : CDStatus = null;
	}
	
	public static TMSContactDetails[] MapFrom(DataSet ds)
	{
		List<TMSContactDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSContactDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ContactDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ContactDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSContactDetails instance = new TMSContactDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSContactDetails Get(System.Int64 cdDetailsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSContactDetails instance;
		
		
		instance = new TMSContactDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContactDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cdDetailsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSContactDetails ID:" + cdDetailsId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String cdTitle, System.String cdName, System.String cdMobile, System.String cdEmailId, System.String cdmsnId, System.String cdgTalkId, System.String cdSkype, System.String cdWebsite, System.String cdExtra1, System.String cdExtra2, System.DateTime? cdDate, System.Int32? cdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContactDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cdTitle, cdName, cdMobile, cdEmailId, cdmsnId, cdgTalkId, cdSkype, cdWebsite, cdExtra1, cdExtra2, cdDate, cdStatus);
		
		if (transaction == null)
		this.CDDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.CDDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String cdTitle, System.String cdName, System.String cdMobile, System.String cdEmailId, System.String cdmsnId, System.String cdgTalkId, System.String cdSkype, System.String cdWebsite, System.String cdExtra1, System.String cdExtra2, System.DateTime? cdDate, System.Int32? cdStatus)
	{
		Insert(cdTitle, cdName, cdMobile, cdEmailId, cdmsnId, cdgTalkId, cdSkype, cdWebsite, cdExtra1, cdExtra2, cdDate, cdStatus, null);
	}
	/// <summary>
	/// Insert current TMSContactDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(CDTitle, CDName, CDMobile, CDEmailId, CDMSNId, CDGTalkId, CDSkype, CDWebsite, CDExtra1, CDExtra2, CDDate, CDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSContactDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? cdDetailsId, System.String cdTitle, System.String cdName, System.String cdMobile, System.String cdEmailId, System.String cdmsnId, System.String cdgTalkId, System.String cdSkype, System.String cdWebsite, System.String cdExtra1, System.String cdExtra2, System.DateTime? cdDate, System.Int32? cdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContactDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@cdDetailsId"].Value = cdDetailsId;
		dbCommand.Parameters["@cdTitle"].Value = cdTitle;
		dbCommand.Parameters["@cdName"].Value = cdName;
		dbCommand.Parameters["@cdMobile"].Value = cdMobile;
		dbCommand.Parameters["@cdEmailId"].Value = cdEmailId;
		dbCommand.Parameters["@cdmsnId"].Value = cdmsnId;
		dbCommand.Parameters["@cdgTalkId"].Value = cdgTalkId;
		dbCommand.Parameters["@cdSkype"].Value = cdSkype;
		dbCommand.Parameters["@cdWebsite"].Value = cdWebsite;
		dbCommand.Parameters["@cdExtra1"].Value = cdExtra1;
		dbCommand.Parameters["@cdExtra2"].Value = cdExtra2;
		dbCommand.Parameters["@cdDate"].Value = cdDate;
		dbCommand.Parameters["@cdStatus"].Value = cdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? cdDetailsId, System.String cdTitle, System.String cdName, System.String cdMobile, System.String cdEmailId, System.String cdmsnId, System.String cdgTalkId, System.String cdSkype, System.String cdWebsite, System.String cdExtra1, System.String cdExtra2, System.DateTime? cdDate, System.Int32? cdStatus)
	{
		Update(cdDetailsId, cdTitle, cdName, cdMobile, cdEmailId, cdmsnId, cdgTalkId, cdSkype, cdWebsite, cdExtra1, cdExtra2, cdDate, cdStatus, null);
	}
	
	public static void Update(TMSContactDetails tMSContactDetails)
	{
		tMSContactDetails.Update();
	}
	
	public static void Update(TMSContactDetails tMSContactDetails, DbTransaction transaction)
	{
		tMSContactDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSContactDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@cdDetailsId"].SourceColumn = "CD_DetailsId";
		dbCommand.Parameters["@cdTitle"].SourceColumn = "CD_Title";
		dbCommand.Parameters["@cdName"].SourceColumn = "CD_Name";
		dbCommand.Parameters["@cdMobile"].SourceColumn = "CD_Mobile";
		dbCommand.Parameters["@cdEmailId"].SourceColumn = "CD_EmailId";
		dbCommand.Parameters["@cdmsnId"].SourceColumn = "CD_MSNId";
		dbCommand.Parameters["@cdgTalkId"].SourceColumn = "CD_GTalkId";
		dbCommand.Parameters["@cdSkype"].SourceColumn = "CD_Skype";
		dbCommand.Parameters["@cdWebsite"].SourceColumn = "CD_Website";
		dbCommand.Parameters["@cdExtra1"].SourceColumn = "CD_Extra1";
		dbCommand.Parameters["@cdExtra2"].SourceColumn = "CD_Extra2";
		dbCommand.Parameters["@cdDate"].SourceColumn = "CD_Date";
		dbCommand.Parameters["@cdStatus"].SourceColumn = "CD_Status";
		
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
	public static void Delete(System.Int64? cdDetailsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContactDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cdDetailsId);
		
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
	public static void Delete(System.Int64? cdDetailsId)
	{
		Delete(
		cdDetailsId);
	}
	
	/// <summary>
	/// Delete current TMSContactDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContactDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, CDDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.CDDetailsId = null;
	}
	
	/// <summary>
	/// Delete current TMSContactDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSContactDetails[] Search(System.Int64? cdDetailsId, System.String cdTitle, System.String cdName, System.String cdMobile, System.String cdEmailId, System.String cdmsnId, System.String cdgTalkId, System.String cdSkype, System.String cdWebsite, System.String cdExtra1, System.String cdExtra2, System.DateTime? cdDate, System.Int32? cdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContactDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, cdDetailsId, cdTitle, cdName, cdMobile, cdEmailId, cdmsnId, cdgTalkId, cdSkype, cdWebsite, cdExtra1, cdExtra2, cdDate, cdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSContactDetails.MapFrom(ds);
	}
	
	
	public static TMSContactDetails[] Search(TMSContactDetails searchObject)
	{
		return Search ( searchObject.CDDetailsId, searchObject.CDTitle, searchObject.CDName, searchObject.CDMobile, searchObject.CDEmailId, searchObject.CDMSNId, searchObject.CDGTalkId, searchObject.CDSkype, searchObject.CDWebsite, searchObject.CDExtra1, searchObject.CDExtra2, searchObject.CDDate, searchObject.CDStatus);
	}
	
	/// <summary>
	/// Returns all TMSContactDetails objects.
	/// </summary>
	/// <returns>List of all TMSContactDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSContactDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

