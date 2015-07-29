/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/25/2012 6:12:35 PM                                    */
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
public partial class TMSVideos
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_Videos]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _vdId;
	private System.String _vdVideoPath;
	private System.Int32? _vdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? VdId
	{
		get
		{
			return _vdId;
		}
		set
		{
			_vdId = value;
		}
	}
	
	public System.String VDVideoPath
	{
		get
		{
			return _vdVideoPath;
		}
		set
		{
			_vdVideoPath = value;
		}
	}
	
	public System.Int32? VDStatus
	{
		get
		{
			return _vdStatus;
		}
		set
		{
			_vdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("VD_ID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_VideoPath", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("VD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (VdId == null)
		dr["VD_ID"] = DBNull.Value;
		else
		dr["VD_ID"] = VdId;
		
		if (VDVideoPath == null)
		dr["VD_VideoPath"] = DBNull.Value;
		else
		dr["VD_VideoPath"] = VDVideoPath;
		
		if (VDStatus == null)
		dr["VD_Status"] = DBNull.Value;
		else
		dr["VD_Status"] = VDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		VdId = dr["VD_ID"] != DBNull.Value ? Convert.ToInt64(dr["VD_ID"]) : VdId = null;
		VDVideoPath = dr["VD_VideoPath"] != DBNull.Value ? Convert.ToString(dr["VD_VideoPath"]) : VDVideoPath = null;
		VDStatus = dr["VD_Status"] != DBNull.Value ? Convert.ToInt32(dr["VD_Status"]) : VDStatus = null;
	}
	
	public static TMSVideos[] MapFrom(DataSet ds)
	{
		List<TMSVideos> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSVideos>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_Videos] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_Videos] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSVideos instance = new TMSVideos();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSVideos Get(System.Int64 vdId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSVideos instance;
		
		
		instance = new TMSVideos();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVideos_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, vdId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSVideos ID:" + vdId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String vdVideoPath, System.Int32? vdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVideos_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, vdVideoPath, vdStatus);
		
		if (transaction == null)
		this.VdId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.VdId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String vdVideoPath, System.Int32? vdStatus)
	{
		Insert(vdVideoPath, vdStatus, null);
	}
	/// <summary>
	/// Insert current TMSVideos to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(VDVideoPath, VDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSVideos to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? vdId, System.String vdVideoPath, System.Int32? vdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVideos_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@vdId"].Value = vdId;
		dbCommand.Parameters["@vdVideoPath"].Value = vdVideoPath;
		dbCommand.Parameters["@vdStatus"].Value = vdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? vdId, System.String vdVideoPath, System.Int32? vdStatus)
	{
		Update(vdId, vdVideoPath, vdStatus, null);
	}
	
	public static void Update(TMSVideos tMSVideos)
	{
		tMSVideos.Update();
	}
	
	public static void Update(TMSVideos tMSVideos, DbTransaction transaction)
	{
		tMSVideos.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSVideos_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@vdId"].SourceColumn = "VD_ID";
		dbCommand.Parameters["@vdVideoPath"].SourceColumn = "VD_VideoPath";
		dbCommand.Parameters["@vdStatus"].SourceColumn = "VD_Status";
		
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
	public static void Delete(System.Int64? vdId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVideos_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, vdId);
		
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
	public static void Delete(System.Int64? vdId)
	{
		Delete(
		vdId);
	}
	
	/// <summary>
	/// Delete current TMSVideos from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVideos_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, VdId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.VdId = null;
	}
	
	/// <summary>
	/// Delete current TMSVideos from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSVideos[] Search(System.Int64? vdId, System.String vdVideoPath, System.Int32? vdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSVideos_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, vdId, vdVideoPath, vdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSVideos.MapFrom(ds);
	}
	
	
	public static TMSVideos[] Search(TMSVideos searchObject)
	{
		return Search ( searchObject.VdId, searchObject.VDVideoPath, searchObject.VDStatus);
	}
	
	/// <summary>
	/// Returns all TMSVideos objects.
	/// </summary>
	/// <returns>List of all TMSVideos objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSVideos[] Search()
	{
		return Search ( null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

