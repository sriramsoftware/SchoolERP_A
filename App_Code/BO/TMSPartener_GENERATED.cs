/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 8/10/2012 5:41:37 PM                                    */
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
public partial class TMSPartener
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_Partener]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ptPartners;
	private System.String _ptTitle;
	private System.String _ptFirstName;
	private System.String _ptLastName;
	private System.String _ptEmailID;
	private System.String _ptMobileNo;
	private System.String _ptCorporateUrl;
	private System.String _ptJobTitle;
	private System.String _ptCountryName;
	private System.String _ptDescription;
	private System.String _ptDescription1;
	private System.DateTime? _ptDate;
	private System.Int32? _ptStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? PTPartners
	{
		get
		{
			return _ptPartners;
		}
		set
		{
			_ptPartners = value;
		}
	}
	
	public System.String PTTitle
	{
		get
		{
			return _ptTitle;
		}
		set
		{
			_ptTitle = value;
		}
	}
	
	public System.String PTFirstName
	{
		get
		{
			return _ptFirstName;
		}
		set
		{
			_ptFirstName = value;
		}
	}
	
	public System.String PTLastName
	{
		get
		{
			return _ptLastName;
		}
		set
		{
			_ptLastName = value;
		}
	}
	
	public System.String PTEmailID
	{
		get
		{
			return _ptEmailID;
		}
		set
		{
			_ptEmailID = value;
		}
	}
	
	public System.String PTMobileNo
	{
		get
		{
			return _ptMobileNo;
		}
		set
		{
			_ptMobileNo = value;
		}
	}
	
	public System.String PTCorporateUrl
	{
		get
		{
			return _ptCorporateUrl;
		}
		set
		{
			_ptCorporateUrl = value;
		}
	}
	
	public System.String PTJobTitle
	{
		get
		{
			return _ptJobTitle;
		}
		set
		{
			_ptJobTitle = value;
		}
	}
	
	public System.String PTCountryName
	{
		get
		{
			return _ptCountryName;
		}
		set
		{
			_ptCountryName = value;
		}
	}
	
	public System.String PTDescription
	{
		get
		{
			return _ptDescription;
		}
		set
		{
			_ptDescription = value;
		}
	}
	
	public System.String PTDescription1
	{
		get
		{
			return _ptDescription1;
		}
		set
		{
			_ptDescription1 = value;
		}
	}
	
	public System.DateTime? PTDate
	{
		get
		{
			return _ptDate;
		}
		set
		{
			_ptDate = value;
		}
	}
	
	public System.Int32? PTStatus
	{
		get
		{
			return _ptStatus;
		}
		set
		{
			_ptStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("PT_Partners", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PT_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PT_FirstName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PT_LastName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PT_EmailID", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PT_MobileNo", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PT_CorporateUrl", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PT_JobTitle", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PT_CountryName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PT_Description", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PT_Description1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PT_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("PT_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (PTPartners == null)
		dr["PT_Partners"] = DBNull.Value;
		else
		dr["PT_Partners"] = PTPartners;
		
		if (PTTitle == null)
		dr["PT_Title"] = DBNull.Value;
		else
		dr["PT_Title"] = PTTitle;
		
		if (PTFirstName == null)
		dr["PT_FirstName"] = DBNull.Value;
		else
		dr["PT_FirstName"] = PTFirstName;
		
		if (PTLastName == null)
		dr["PT_LastName"] = DBNull.Value;
		else
		dr["PT_LastName"] = PTLastName;
		
		if (PTEmailID == null)
		dr["PT_EmailID"] = DBNull.Value;
		else
		dr["PT_EmailID"] = PTEmailID;
		
		if (PTMobileNo == null)
		dr["PT_MobileNo"] = DBNull.Value;
		else
		dr["PT_MobileNo"] = PTMobileNo;
		
		if (PTCorporateUrl == null)
		dr["PT_CorporateUrl"] = DBNull.Value;
		else
		dr["PT_CorporateUrl"] = PTCorporateUrl;
		
		if (PTJobTitle == null)
		dr["PT_JobTitle"] = DBNull.Value;
		else
		dr["PT_JobTitle"] = PTJobTitle;
		
		if (PTCountryName == null)
		dr["PT_CountryName"] = DBNull.Value;
		else
		dr["PT_CountryName"] = PTCountryName;
		
		if (PTDescription == null)
		dr["PT_Description"] = DBNull.Value;
		else
		dr["PT_Description"] = PTDescription;
		
		if (PTDescription1 == null)
		dr["PT_Description1"] = DBNull.Value;
		else
		dr["PT_Description1"] = PTDescription1;
		
		if (PTDate == null)
		dr["PT_Date"] = DBNull.Value;
		else
		dr["PT_Date"] = PTDate;
		
		if (PTStatus == null)
		dr["PT_Status"] = DBNull.Value;
		else
		dr["PT_Status"] = PTStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		PTPartners = dr["PT_Partners"] != DBNull.Value ? Convert.ToInt64(dr["PT_Partners"]) : PTPartners = null;
		PTTitle = dr["PT_Title"] != DBNull.Value ? Convert.ToString(dr["PT_Title"]) : PTTitle = null;
		PTFirstName = dr["PT_FirstName"] != DBNull.Value ? Convert.ToString(dr["PT_FirstName"]) : PTFirstName = null;
		PTLastName = dr["PT_LastName"] != DBNull.Value ? Convert.ToString(dr["PT_LastName"]) : PTLastName = null;
		PTEmailID = dr["PT_EmailID"] != DBNull.Value ? Convert.ToString(dr["PT_EmailID"]) : PTEmailID = null;
		PTMobileNo = dr["PT_MobileNo"] != DBNull.Value ? Convert.ToString(dr["PT_MobileNo"]) : PTMobileNo = null;
		PTCorporateUrl = dr["PT_CorporateUrl"] != DBNull.Value ? Convert.ToString(dr["PT_CorporateUrl"]) : PTCorporateUrl = null;
		PTJobTitle = dr["PT_JobTitle"] != DBNull.Value ? Convert.ToString(dr["PT_JobTitle"]) : PTJobTitle = null;
		PTCountryName = dr["PT_CountryName"] != DBNull.Value ? Convert.ToString(dr["PT_CountryName"]) : PTCountryName = null;
		PTDescription = dr["PT_Description"] != DBNull.Value ? Convert.ToString(dr["PT_Description"]) : PTDescription = null;
		PTDescription1 = dr["PT_Description1"] != DBNull.Value ? Convert.ToString(dr["PT_Description1"]) : PTDescription1 = null;
		PTDate = dr["PT_Date"] != DBNull.Value ? Convert.ToDateTime(dr["PT_Date"]) : PTDate = null;
		PTStatus = dr["PT_Status"] != DBNull.Value ? Convert.ToInt32(dr["PT_Status"]) : PTStatus = null;
	}
	
	public static TMSPartener[] MapFrom(DataSet ds)
	{
		List<TMSPartener> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSPartener>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_Partener] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_Partener] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSPartener instance = new TMSPartener();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSPartener Get(System.Int64 ptPartners)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSPartener instance;
		
		
		instance = new TMSPartener();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPartener_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ptPartners);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSPartener ID:" + ptPartners.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String ptTitle, System.String ptFirstName, System.String ptLastName, System.String ptEmailID, System.String ptMobileNo, System.String ptCorporateUrl, System.String ptJobTitle, System.String ptCountryName, System.String ptDescription, System.String ptDescription1, System.DateTime? ptDate, System.Int32? ptStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPartener_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ptTitle, ptFirstName, ptLastName, ptEmailID, ptMobileNo, ptCorporateUrl, ptJobTitle, ptCountryName, ptDescription, ptDescription1, ptDate, ptStatus);
		
		if (transaction == null)
		this.PTPartners = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.PTPartners = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String ptTitle, System.String ptFirstName, System.String ptLastName, System.String ptEmailID, System.String ptMobileNo, System.String ptCorporateUrl, System.String ptJobTitle, System.String ptCountryName, System.String ptDescription, System.String ptDescription1, System.DateTime? ptDate, System.Int32? ptStatus)
	{
		Insert(ptTitle, ptFirstName, ptLastName, ptEmailID, ptMobileNo, ptCorporateUrl, ptJobTitle, ptCountryName, ptDescription, ptDescription1, ptDate, ptStatus, null);
	}
	/// <summary>
	/// Insert current TMSPartener to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(PTTitle, PTFirstName, PTLastName, PTEmailID, PTMobileNo, PTCorporateUrl, PTJobTitle, PTCountryName, PTDescription, PTDescription1, PTDate, PTStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSPartener to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ptPartners, System.String ptTitle, System.String ptFirstName, System.String ptLastName, System.String ptEmailID, System.String ptMobileNo, System.String ptCorporateUrl, System.String ptJobTitle, System.String ptCountryName, System.String ptDescription, System.String ptDescription1, System.DateTime? ptDate, System.Int32? ptStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPartener_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ptPartners"].Value = ptPartners;
		dbCommand.Parameters["@ptTitle"].Value = ptTitle;
		dbCommand.Parameters["@ptFirstName"].Value = ptFirstName;
		dbCommand.Parameters["@ptLastName"].Value = ptLastName;
		dbCommand.Parameters["@ptEmailID"].Value = ptEmailID;
		dbCommand.Parameters["@ptMobileNo"].Value = ptMobileNo;
		dbCommand.Parameters["@ptCorporateUrl"].Value = ptCorporateUrl;
		dbCommand.Parameters["@ptJobTitle"].Value = ptJobTitle;
		dbCommand.Parameters["@ptCountryName"].Value = ptCountryName;
		dbCommand.Parameters["@ptDescription"].Value = ptDescription;
		dbCommand.Parameters["@ptDescription1"].Value = ptDescription1;
		dbCommand.Parameters["@ptDate"].Value = ptDate;
		dbCommand.Parameters["@ptStatus"].Value = ptStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ptPartners, System.String ptTitle, System.String ptFirstName, System.String ptLastName, System.String ptEmailID, System.String ptMobileNo, System.String ptCorporateUrl, System.String ptJobTitle, System.String ptCountryName, System.String ptDescription, System.String ptDescription1, System.DateTime? ptDate, System.Int32? ptStatus)
	{
		Update(ptPartners, ptTitle, ptFirstName, ptLastName, ptEmailID, ptMobileNo, ptCorporateUrl, ptJobTitle, ptCountryName, ptDescription, ptDescription1, ptDate, ptStatus, null);
	}
	
	public static void Update(TMSPartener tMSPartener)
	{
		tMSPartener.Update();
	}
	
	public static void Update(TMSPartener tMSPartener, DbTransaction transaction)
	{
		tMSPartener.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSPartener_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ptPartners"].SourceColumn = "PT_Partners";
		dbCommand.Parameters["@ptTitle"].SourceColumn = "PT_Title";
		dbCommand.Parameters["@ptFirstName"].SourceColumn = "PT_FirstName";
		dbCommand.Parameters["@ptLastName"].SourceColumn = "PT_LastName";
		dbCommand.Parameters["@ptEmailID"].SourceColumn = "PT_EmailID";
		dbCommand.Parameters["@ptMobileNo"].SourceColumn = "PT_MobileNo";
		dbCommand.Parameters["@ptCorporateUrl"].SourceColumn = "PT_CorporateUrl";
		dbCommand.Parameters["@ptJobTitle"].SourceColumn = "PT_JobTitle";
		dbCommand.Parameters["@ptCountryName"].SourceColumn = "PT_CountryName";
		dbCommand.Parameters["@ptDescription"].SourceColumn = "PT_Description";
		dbCommand.Parameters["@ptDescription1"].SourceColumn = "PT_Description1";
		dbCommand.Parameters["@ptDate"].SourceColumn = "PT_Date";
		dbCommand.Parameters["@ptStatus"].SourceColumn = "PT_Status";
		
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
	public static void Delete(System.Int64? ptPartners, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPartener_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ptPartners);
		
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
	public static void Delete(System.Int64? ptPartners)
	{
		Delete(
		ptPartners);
	}
	
	/// <summary>
	/// Delete current TMSPartener from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPartener_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, PTPartners);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.PTPartners = null;
	}
	
	/// <summary>
	/// Delete current TMSPartener from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSPartener[] Search(System.Int64? ptPartners, System.String ptTitle, System.String ptFirstName, System.String ptLastName, System.String ptEmailID, System.String ptMobileNo, System.String ptCorporateUrl, System.String ptJobTitle, System.String ptCountryName, System.String ptDescription, System.String ptDescription1, System.DateTime? ptDate, System.Int32? ptStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSPartener_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ptPartners, ptTitle, ptFirstName, ptLastName, ptEmailID, ptMobileNo, ptCorporateUrl, ptJobTitle, ptCountryName, ptDescription, ptDescription1, ptDate, ptStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSPartener.MapFrom(ds);
	}
	
	
	public static TMSPartener[] Search(TMSPartener searchObject)
	{
		return Search ( searchObject.PTPartners, searchObject.PTTitle, searchObject.PTFirstName, searchObject.PTLastName, searchObject.PTEmailID, searchObject.PTMobileNo, searchObject.PTCorporateUrl, searchObject.PTJobTitle, searchObject.PTCountryName, searchObject.PTDescription, searchObject.PTDescription1, searchObject.PTDate, searchObject.PTStatus);
	}
	
	/// <summary>
	/// Returns all TMSPartener objects.
	/// </summary>
	/// <returns>List of all TMSPartener objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSPartener[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

