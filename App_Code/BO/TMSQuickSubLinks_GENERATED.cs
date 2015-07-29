/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/29/2012 9:10:17 PM                                    */
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
public partial class TMSQuickSubLinks
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_QuickSubLinks]";
	
	#endregion
	
	
	#region Fields
	private System.Int32? _qslId;
	private System.Int32? _qslLinkId;
	private System.Int32? _qslReferID;
	private System.String _qslRole;
	private System.String _qslImage;
	private System.String _qslImage1;
	private System.String _qslUrl;
	private System.String _qslDescription;
	private System.Boolean? _qslStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int32? QSLId
	{
		get
		{
			return _qslId;
		}
		set
		{
			_qslId = value;
		}
	}
	
	public System.Int32? QSLLinkId
	{
		get
		{
			return _qslLinkId;
		}
		set
		{
			_qslLinkId = value;
		}
	}
	
	public System.Int32? QSLReferID
	{
		get
		{
			return _qslReferID;
		}
		set
		{
			_qslReferID = value;
		}
	}
	
	public System.String QSLRole
	{
		get
		{
			return _qslRole;
		}
		set
		{
			_qslRole = value;
		}
	}
	
	public System.String QSLImage
	{
		get
		{
			return _qslImage;
		}
		set
		{
			_qslImage = value;
		}
	}
	
	public System.String QSLImage1
	{
		get
		{
			return _qslImage1;
		}
		set
		{
			_qslImage1 = value;
		}
	}
	
	public System.String QslUrl
	{
		get
		{
			return _qslUrl;
		}
		set
		{
			_qslUrl = value;
		}
	}
	
	public System.String QSLDescription
	{
		get
		{
			return _qslDescription;
		}
		set
		{
			_qslDescription = value;
		}
	}
	
	public System.Boolean? QSLStatus
	{
		get
		{
			return _qslStatus;
		}
		set
		{
			_qslStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("QSL_Id", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("QSL_LinkId", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("QSL_ReferID", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("QSL_Role", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("QSL_Image", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("QSL_Image1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("QSL_URL", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("QSL_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("QSL_Status", typeof(System.Boolean) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (QSLId == null)
		dr["QSL_Id"] = DBNull.Value;
		else
		dr["QSL_Id"] = QSLId;
		
		if (QSLLinkId == null)
		dr["QSL_LinkId"] = DBNull.Value;
		else
		dr["QSL_LinkId"] = QSLLinkId;
		
		if (QSLReferID == null)
		dr["QSL_ReferID"] = DBNull.Value;
		else
		dr["QSL_ReferID"] = QSLReferID;
		
		if (QSLRole == null)
		dr["QSL_Role"] = DBNull.Value;
		else
		dr["QSL_Role"] = QSLRole;
		
		if (QSLImage == null)
		dr["QSL_Image"] = DBNull.Value;
		else
		dr["QSL_Image"] = QSLImage;
		
		if (QSLImage1 == null)
		dr["QSL_Image1"] = DBNull.Value;
		else
		dr["QSL_Image1"] = QSLImage1;
		
		if (QslUrl == null)
		dr["QSL_URL"] = DBNull.Value;
		else
		dr["QSL_URL"] = QslUrl;
		
		if (QSLDescription == null)
		dr["QSL_Description"] = DBNull.Value;
		else
		dr["QSL_Description"] = QSLDescription;
		
		if (QSLStatus == null)
		dr["QSL_Status"] = DBNull.Value;
		else
		dr["QSL_Status"] = QSLStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		QSLId = dr["QSL_Id"] != DBNull.Value ? Convert.ToInt32(dr["QSL_Id"]) : QSLId = null;
		QSLLinkId = dr["QSL_LinkId"] != DBNull.Value ? Convert.ToInt32(dr["QSL_LinkId"]) : QSLLinkId = null;
		QSLReferID = dr["QSL_ReferID"] != DBNull.Value ? Convert.ToInt32(dr["QSL_ReferID"]) : QSLReferID = null;
		QSLRole = dr["QSL_Role"] != DBNull.Value ? Convert.ToString(dr["QSL_Role"]) : QSLRole = null;
		QSLImage = dr["QSL_Image"] != DBNull.Value ? Convert.ToString(dr["QSL_Image"]) : QSLImage = null;
		QSLImage1 = dr["QSL_Image1"] != DBNull.Value ? Convert.ToString(dr["QSL_Image1"]) : QSLImage1 = null;
		QslUrl = dr["QSL_URL"] != DBNull.Value ? Convert.ToString(dr["QSL_URL"]) : QslUrl = null;
		QSLDescription = dr["QSL_Description"] != DBNull.Value ? Convert.ToString(dr["QSL_Description"]) : QSLDescription = null;
		QSLStatus = dr["QSL_Status"] != DBNull.Value ? Convert.ToBoolean(dr["QSL_Status"]) : QSLStatus = null;
	}
	
	public static TMSQuickSubLinks[] MapFrom(DataSet ds)
	{
		List<TMSQuickSubLinks> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSQuickSubLinks>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_QuickSubLinks] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_QuickSubLinks] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSQuickSubLinks instance = new TMSQuickSubLinks();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSQuickSubLinks Get(System.Int32 qslId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSQuickSubLinks instance;
		
		
		instance = new TMSQuickSubLinks();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQuickSubLinks_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, qslId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSQuickSubLinks ID:" + qslId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int32? qslLinkId, System.Int32? qslReferID, System.String qslRole, System.String qslImage, System.String qslImage1, System.String qslUrl, System.String qslDescription, System.Boolean? qslStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQuickSubLinks_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, qslLinkId, qslReferID, qslRole, qslImage, qslImage1, qslUrl, qslDescription, qslStatus);
		
		if (transaction == null)
		this.QSLId = Convert.ToInt32(db.ExecuteScalar(dbCommand));
		else
		this.QSLId = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int32? qslLinkId, System.Int32? qslReferID, System.String qslRole, System.String qslImage, System.String qslImage1, System.String qslUrl, System.String qslDescription, System.Boolean? qslStatus)
	{
		Insert(qslLinkId, qslReferID, qslRole, qslImage, qslImage1, qslUrl, qslDescription, qslStatus, null);
	}
	/// <summary>
	/// Insert current TMSQuickSubLinks to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(QSLLinkId, QSLReferID, QSLRole, QSLImage, QSLImage1, QslUrl, QSLDescription, QSLStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSQuickSubLinks to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int32? qslId, System.Int32? qslLinkId, System.Int32? qslReferID, System.String qslRole, System.String qslImage, System.String qslImage1, System.String qslUrl, System.String qslDescription, System.Boolean? qslStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQuickSubLinks_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@qslId"].Value = qslId;
		dbCommand.Parameters["@qslLinkId"].Value = qslLinkId;
		dbCommand.Parameters["@qslReferID"].Value = qslReferID;
		dbCommand.Parameters["@qslRole"].Value = qslRole;
		dbCommand.Parameters["@qslImage"].Value = qslImage;
		dbCommand.Parameters["@qslImage1"].Value = qslImage1;
		dbCommand.Parameters["@qslUrl"].Value = qslUrl;
		dbCommand.Parameters["@qslDescription"].Value = qslDescription;
		dbCommand.Parameters["@qslStatus"].Value = qslStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int32? qslId, System.Int32? qslLinkId, System.Int32? qslReferID, System.String qslRole, System.String qslImage, System.String qslImage1, System.String qslUrl, System.String qslDescription, System.Boolean? qslStatus)
	{
		Update(qslId, qslLinkId, qslReferID, qslRole, qslImage, qslImage1, qslUrl, qslDescription, qslStatus, null);
	}
	
	public static void Update(TMSQuickSubLinks tMSQuickSubLinks)
	{
		tMSQuickSubLinks.Update();
	}
	
	public static void Update(TMSQuickSubLinks tMSQuickSubLinks, DbTransaction transaction)
	{
		tMSQuickSubLinks.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSQuickSubLinks_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@qslId"].SourceColumn = "QSL_Id";
		dbCommand.Parameters["@qslLinkId"].SourceColumn = "QSL_LinkId";
		dbCommand.Parameters["@qslReferID"].SourceColumn = "QSL_ReferID";
		dbCommand.Parameters["@qslRole"].SourceColumn = "QSL_Role";
		dbCommand.Parameters["@qslImage"].SourceColumn = "QSL_Image";
		dbCommand.Parameters["@qslImage1"].SourceColumn = "QSL_Image1";
		dbCommand.Parameters["@qslUrl"].SourceColumn = "QSL_URL";
		dbCommand.Parameters["@qslDescription"].SourceColumn = "QSL_Description";
		dbCommand.Parameters["@qslStatus"].SourceColumn = "QSL_Status";
		
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
	public static void Delete(System.Int32? qslId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQuickSubLinks_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, qslId);
		
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
	public static void Delete(System.Int32? qslId)
	{
		Delete(
		qslId);
	}
	
	/// <summary>
	/// Delete current TMSQuickSubLinks from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQuickSubLinks_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, QSLId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.QSLId = null;
	}
	
	/// <summary>
	/// Delete current TMSQuickSubLinks from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSQuickSubLinks[] Search(System.Int32? qslId, System.Int32? qslLinkId, System.Int32? qslReferID, System.String qslRole, System.String qslImage, System.String qslImage1, System.String qslUrl, System.String qslDescription, System.Boolean? qslStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSQuickSubLinks_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, qslId, qslLinkId, qslReferID, qslRole, qslImage, qslImage1, qslUrl, qslDescription, qslStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSQuickSubLinks.MapFrom(ds);
	}
	
	
	public static TMSQuickSubLinks[] Search(TMSQuickSubLinks searchObject)
	{
		return Search ( searchObject.QSLId, searchObject.QSLLinkId, searchObject.QSLReferID, searchObject.QSLRole, searchObject.QSLImage, searchObject.QSLImage1, searchObject.QslUrl, searchObject.QSLDescription, searchObject.QSLStatus);
	}
	
	/// <summary>
	/// Returns all TMSQuickSubLinks objects.
	/// </summary>
	/// <returns>List of all TMSQuickSubLinks objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSQuickSubLinks[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

