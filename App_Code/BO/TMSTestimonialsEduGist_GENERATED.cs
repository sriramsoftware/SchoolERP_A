/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/10/2012 5:14:51 PM                                    */
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
public partial class TMSTestimonialsEduGist
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_TestimonialsEduGist]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _tsId;
	private System.String _tsName;
	private System.String _tsPhotopath;
	private System.String _tsTestimonials;
	private System.DateTime? _tsDate;
	private System.Int32? _tsStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? TsId
	{
		get
		{
			return _tsId;
		}
		set
		{
			_tsId = value;
		}
	}
	
	public System.String TSName
	{
		get
		{
			return _tsName;
		}
		set
		{
			_tsName = value;
		}
	}
	
	public System.String TSPhotopath
	{
		get
		{
			return _tsPhotopath;
		}
		set
		{
			_tsPhotopath = value;
		}
	}
	
	public System.String TSTestimonials
	{
		get
		{
			return _tsTestimonials;
		}
		set
		{
			_tsTestimonials = value;
		}
	}
	
	public System.DateTime? TSDate
	{
		get
		{
			return _tsDate;
		}
		set
		{
			_tsDate = value;
		}
	}
	
	public System.Int32? TSStatus
	{
		get
		{
			return _tsStatus;
		}
		set
		{
			_tsStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("TS_ID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TS_Name", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TS_Photopath", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TS_Testimonials", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TS_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("TS_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (TsId == null)
		dr["TS_ID"] = DBNull.Value;
		else
		dr["TS_ID"] = TsId;
		
		if (TSName == null)
		dr["TS_Name"] = DBNull.Value;
		else
		dr["TS_Name"] = TSName;
		
		if (TSPhotopath == null)
		dr["TS_Photopath"] = DBNull.Value;
		else
		dr["TS_Photopath"] = TSPhotopath;
		
		if (TSTestimonials == null)
		dr["TS_Testimonials"] = DBNull.Value;
		else
		dr["TS_Testimonials"] = TSTestimonials;
		
		if (TSDate == null)
		dr["TS_Date"] = DBNull.Value;
		else
		dr["TS_Date"] = TSDate;
		
		if (TSStatus == null)
		dr["TS_Status"] = DBNull.Value;
		else
		dr["TS_Status"] = TSStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		TsId = dr["TS_ID"] != DBNull.Value ? Convert.ToInt64(dr["TS_ID"]) : TsId = null;
		TSName = dr["TS_Name"] != DBNull.Value ? Convert.ToString(dr["TS_Name"]) : TSName = null;
		TSPhotopath = dr["TS_Photopath"] != DBNull.Value ? Convert.ToString(dr["TS_Photopath"]) : TSPhotopath = null;
		TSTestimonials = dr["TS_Testimonials"] != DBNull.Value ? Convert.ToString(dr["TS_Testimonials"]) : TSTestimonials = null;
		TSDate = dr["TS_Date"] != DBNull.Value ? Convert.ToDateTime(dr["TS_Date"]) : TSDate = null;
		TSStatus = dr["TS_Status"] != DBNull.Value ? Convert.ToInt32(dr["TS_Status"]) : TSStatus = null;
	}
	
	public static TMSTestimonialsEduGist[] MapFrom(DataSet ds)
	{
		List<TMSTestimonialsEduGist> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSTestimonialsEduGist>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_TestimonialsEduGist] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_TestimonialsEduGist] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSTestimonialsEduGist instance = new TMSTestimonialsEduGist();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSTestimonialsEduGist Get(System.Int64 tsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSTestimonialsEduGist instance;
		
		
		instance = new TMSTestimonialsEduGist();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTestimonialsEduGist_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSTestimonialsEduGist ID:" + tsId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String tsName, System.String tsPhotopath, System.String tsTestimonials, System.DateTime? tsDate, System.Int32? tsStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTestimonialsEduGist_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tsName, tsPhotopath, tsTestimonials, tsDate, tsStatus);
		
		if (transaction == null)
		this.TsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.TsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String tsName, System.String tsPhotopath, System.String tsTestimonials, System.DateTime? tsDate, System.Int32? tsStatus)
	{
		Insert(tsName, tsPhotopath, tsTestimonials, tsDate, tsStatus, null);
	}
	/// <summary>
	/// Insert current TMSTestimonialsEduGist to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(TSName, TSPhotopath, TSTestimonials, TSDate, TSStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSTestimonialsEduGist to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? tsId, System.String tsName, System.String tsPhotopath, System.String tsTestimonials, System.DateTime? tsDate, System.Int32? tsStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTestimonialsEduGist_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@tsId"].Value = tsId;
		dbCommand.Parameters["@tsName"].Value = tsName;
		dbCommand.Parameters["@tsPhotopath"].Value = tsPhotopath;
		dbCommand.Parameters["@tsTestimonials"].Value = tsTestimonials;
		dbCommand.Parameters["@tsDate"].Value = tsDate;
		dbCommand.Parameters["@tsStatus"].Value = tsStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? tsId, System.String tsName, System.String tsPhotopath, System.String tsTestimonials, System.DateTime? tsDate, System.Int32? tsStatus)
	{
		Update(tsId, tsName, tsPhotopath, tsTestimonials, tsDate, tsStatus, null);
	}
	
	public static void Update(TMSTestimonialsEduGist tMSTestimonialsEduGist)
	{
		tMSTestimonialsEduGist.Update();
	}
	
	public static void Update(TMSTestimonialsEduGist tMSTestimonialsEduGist, DbTransaction transaction)
	{
		tMSTestimonialsEduGist.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSTestimonialsEduGist_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@tsId"].SourceColumn = "TS_ID";
		dbCommand.Parameters["@tsName"].SourceColumn = "TS_Name";
		dbCommand.Parameters["@tsPhotopath"].SourceColumn = "TS_Photopath";
		dbCommand.Parameters["@tsTestimonials"].SourceColumn = "TS_Testimonials";
		dbCommand.Parameters["@tsDate"].SourceColumn = "TS_Date";
		dbCommand.Parameters["@tsStatus"].SourceColumn = "TS_Status";
		
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
	public static void Delete(System.Int64? tsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTestimonialsEduGist_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tsId);
		
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
	public static void Delete(System.Int64? tsId)
	{
		Delete(
		tsId);
	}
	
	/// <summary>
	/// Delete current TMSTestimonialsEduGist from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTestimonialsEduGist_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, TsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.TsId = null;
	}
	
	/// <summary>
	/// Delete current TMSTestimonialsEduGist from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSTestimonialsEduGist[] Search(System.Int64? tsId, System.String tsName, System.String tsPhotopath, System.String tsTestimonials, System.DateTime? tsDate, System.Int32? tsStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTestimonialsEduGist_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tsId, tsName, tsPhotopath, tsTestimonials, tsDate, tsStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSTestimonialsEduGist.MapFrom(ds);
	}
	
	
	public static TMSTestimonialsEduGist[] Search(TMSTestimonialsEduGist searchObject)
	{
		return Search ( searchObject.TsId, searchObject.TSName, searchObject.TSPhotopath, searchObject.TSTestimonials, searchObject.TSDate, searchObject.TSStatus);
	}
	
	/// <summary>
	/// Returns all TMSTestimonialsEduGist objects.
	/// </summary>
	/// <returns>List of all TMSTestimonialsEduGist objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSTestimonialsEduGist[] Search()
	{
		return Search ( null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

