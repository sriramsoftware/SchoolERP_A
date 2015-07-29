/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 7/10/2012 5:45:27 PM                                    */
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
public partial class TMSContactUs
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ContactUs]";
	
	#endregion
	
	
	#region Fields
	private System.Int32? _contactID;
	private System.String _contactName;
	private System.String _contactEmail;
	private System.String _contactPhone;
	private System.String _contactSubject;
	private System.String _contactComment;
	private System.String _contactReply;
	private System.Int32? _contactReplyStatus;
	private System.Int32? _contactStatus;
	private System.DateTime? _contactDate;
	
	#endregion
	
	
	#region Properties
	public System.Int32? ContactID
	{
		get
		{
			return _contactID;
		}
		set
		{
			_contactID = value;
		}
	}
	
	public System.String ContactName
	{
		get
		{
			return _contactName;
		}
		set
		{
			_contactName = value;
		}
	}
	
	public System.String ContactEmail
	{
		get
		{
			return _contactEmail;
		}
		set
		{
			_contactEmail = value;
		}
	}
	
	public System.String ContactPhone
	{
		get
		{
			return _contactPhone;
		}
		set
		{
			_contactPhone = value;
		}
	}
	
	public System.String ContactSubject
	{
		get
		{
			return _contactSubject;
		}
		set
		{
			_contactSubject = value;
		}
	}
	
	public System.String ContactComment
	{
		get
		{
			return _contactComment;
		}
		set
		{
			_contactComment = value;
		}
	}
	
	public System.String ContactReply
	{
		get
		{
			return _contactReply;
		}
		set
		{
			_contactReply = value;
		}
	}
	
	public System.Int32? ContactReplyStatus
	{
		get
		{
			return _contactReplyStatus;
		}
		set
		{
			_contactReplyStatus = value;
		}
	}
	
	public System.Int32? ContactStatus
	{
		get
		{
			return _contactStatus;
		}
		set
		{
			_contactStatus = value;
		}
	}
	
	public System.DateTime? ContactDate
	{
		get
		{
			return _contactDate;
		}
		set
		{
			_contactDate = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("ContactID", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("ContactName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ContactEmail", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ContactPhone", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ContactSubject", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ContactComment", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ContactReply", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ContactReplyStatus", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("ContactStatus", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("ContactDate", typeof(System.DateTime) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ContactID == null)
		dr["ContactID"] = DBNull.Value;
		else
		dr["ContactID"] = ContactID;
		
		if (ContactName == null)
		dr["ContactName"] = DBNull.Value;
		else
		dr["ContactName"] = ContactName;
		
		if (ContactEmail == null)
		dr["ContactEmail"] = DBNull.Value;
		else
		dr["ContactEmail"] = ContactEmail;
		
		if (ContactPhone == null)
		dr["ContactPhone"] = DBNull.Value;
		else
		dr["ContactPhone"] = ContactPhone;
		
		if (ContactSubject == null)
		dr["ContactSubject"] = DBNull.Value;
		else
		dr["ContactSubject"] = ContactSubject;
		
		if (ContactComment == null)
		dr["ContactComment"] = DBNull.Value;
		else
		dr["ContactComment"] = ContactComment;
		
		if (ContactReply == null)
		dr["ContactReply"] = DBNull.Value;
		else
		dr["ContactReply"] = ContactReply;
		
		if (ContactReplyStatus == null)
		dr["ContactReplyStatus"] = DBNull.Value;
		else
		dr["ContactReplyStatus"] = ContactReplyStatus;
		
		if (ContactStatus == null)
		dr["ContactStatus"] = DBNull.Value;
		else
		dr["ContactStatus"] = ContactStatus;
		
		if (ContactDate == null)
		dr["ContactDate"] = DBNull.Value;
		else
		dr["ContactDate"] = ContactDate;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ContactID = dr["ContactID"] != DBNull.Value ? Convert.ToInt32(dr["ContactID"]) : ContactID = null;
		ContactName = dr["ContactName"] != DBNull.Value ? Convert.ToString(dr["ContactName"]) : ContactName = null;
		ContactEmail = dr["ContactEmail"] != DBNull.Value ? Convert.ToString(dr["ContactEmail"]) : ContactEmail = null;
		ContactPhone = dr["ContactPhone"] != DBNull.Value ? Convert.ToString(dr["ContactPhone"]) : ContactPhone = null;
		ContactSubject = dr["ContactSubject"] != DBNull.Value ? Convert.ToString(dr["ContactSubject"]) : ContactSubject = null;
		ContactComment = dr["ContactComment"] != DBNull.Value ? Convert.ToString(dr["ContactComment"]) : ContactComment = null;
		ContactReply = dr["ContactReply"] != DBNull.Value ? Convert.ToString(dr["ContactReply"]) : ContactReply = null;
		ContactReplyStatus = dr["ContactReplyStatus"] != DBNull.Value ? Convert.ToInt32(dr["ContactReplyStatus"]) : ContactReplyStatus = null;
		ContactStatus = dr["ContactStatus"] != DBNull.Value ? Convert.ToInt32(dr["ContactStatus"]) : ContactStatus = null;
		ContactDate = dr["ContactDate"] != DBNull.Value ? Convert.ToDateTime(dr["ContactDate"]) : ContactDate = null;
	}
	
	public static TMSContactUs[] MapFrom(DataSet ds)
	{
		List<TMSContactUs> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSContactUs>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ContactUs] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ContactUs] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSContactUs instance = new TMSContactUs();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSContactUs Get(System.Int32 contactID)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSContactUs instance;
		
		
		instance = new TMSContactUs();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContactUs_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, contactID);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSContactUs ID:" + contactID.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String contactName, System.String contactEmail, System.String contactPhone, System.String contactSubject, System.String contactComment, System.String contactReply, System.Int32? contactReplyStatus, System.Int32? contactStatus, System.DateTime? contactDate, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContactUs_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, contactName, contactEmail, contactPhone, contactSubject, contactComment, contactReply, contactReplyStatus, contactStatus, contactDate);
		
		if (transaction == null)
		this.ContactID = Convert.ToInt32(db.ExecuteScalar(dbCommand));
		else
		this.ContactID = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String contactName, System.String contactEmail, System.String contactPhone, System.String contactSubject, System.String contactComment, System.String contactReply, System.Int32? contactReplyStatus, System.Int32? contactStatus, System.DateTime? contactDate)
	{
		Insert(contactName, contactEmail, contactPhone, contactSubject, contactComment, contactReply, contactReplyStatus, contactStatus, contactDate, null);
	}
	/// <summary>
	/// Insert current TMSContactUs to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ContactName, ContactEmail, ContactPhone, ContactSubject, ContactComment, ContactReply, ContactReplyStatus, ContactStatus, ContactDate, transaction);
	}
	
	/// <summary>
	/// Insert current TMSContactUs to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int32? contactID, System.String contactName, System.String contactEmail, System.String contactPhone, System.String contactSubject, System.String contactComment, System.String contactReply, System.Int32? contactReplyStatus, System.Int32? contactStatus, System.DateTime? contactDate, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContactUs_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@contactID"].Value = contactID;
		dbCommand.Parameters["@contactName"].Value = contactName;
		dbCommand.Parameters["@contactEmail"].Value = contactEmail;
		dbCommand.Parameters["@contactPhone"].Value = contactPhone;
		dbCommand.Parameters["@contactSubject"].Value = contactSubject;
		dbCommand.Parameters["@contactComment"].Value = contactComment;
		dbCommand.Parameters["@contactReply"].Value = contactReply;
		dbCommand.Parameters["@contactReplyStatus"].Value = contactReplyStatus;
		dbCommand.Parameters["@contactStatus"].Value = contactStatus;
		dbCommand.Parameters["@contactDate"].Value = contactDate;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int32? contactID, System.String contactName, System.String contactEmail, System.String contactPhone, System.String contactSubject, System.String contactComment, System.String contactReply, System.Int32? contactReplyStatus, System.Int32? contactStatus, System.DateTime? contactDate)
	{
		Update(contactID, contactName, contactEmail, contactPhone, contactSubject, contactComment, contactReply, contactReplyStatus, contactStatus, contactDate, null);
	}
	
	public static void Update(TMSContactUs tMSContactUs)
	{
		tMSContactUs.Update();
	}
	
	public static void Update(TMSContactUs tMSContactUs, DbTransaction transaction)
	{
		tMSContactUs.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSContactUs_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@contactID"].SourceColumn = "ContactID";
		dbCommand.Parameters["@contactName"].SourceColumn = "ContactName";
		dbCommand.Parameters["@contactEmail"].SourceColumn = "ContactEmail";
		dbCommand.Parameters["@contactPhone"].SourceColumn = "ContactPhone";
		dbCommand.Parameters["@contactSubject"].SourceColumn = "ContactSubject";
		dbCommand.Parameters["@contactComment"].SourceColumn = "ContactComment";
		dbCommand.Parameters["@contactReply"].SourceColumn = "ContactReply";
		dbCommand.Parameters["@contactReplyStatus"].SourceColumn = "ContactReplyStatus";
		dbCommand.Parameters["@contactStatus"].SourceColumn = "ContactStatus";
		dbCommand.Parameters["@contactDate"].SourceColumn = "ContactDate";
		
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
	public static void Delete(System.Int32? contactID, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContactUs_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, contactID);
		
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
	public static void Delete(System.Int32? contactID)
	{
		Delete(
		contactID);
	}
	
	/// <summary>
	/// Delete current TMSContactUs from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContactUs_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ContactID);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ContactID = null;
	}
	
	/// <summary>
	/// Delete current TMSContactUs from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSContactUs[] Search(System.Int32? contactID, System.String contactName, System.String contactEmail, System.String contactPhone, System.String contactSubject, System.String contactComment, System.String contactReply, System.Int32? contactReplyStatus, System.Int32? contactStatus, System.DateTime? contactDate)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSContactUs_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, contactID, contactName, contactEmail, contactPhone, contactSubject, contactComment, contactReply, contactReplyStatus, contactStatus, contactDate);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSContactUs.MapFrom(ds);
	}
	
	
	public static TMSContactUs[] Search(TMSContactUs searchObject)
	{
		return Search ( searchObject.ContactID, searchObject.ContactName, searchObject.ContactEmail, searchObject.ContactPhone, searchObject.ContactSubject, searchObject.ContactComment, searchObject.ContactReply, searchObject.ContactReplyStatus, searchObject.ContactStatus, searchObject.ContactDate);
	}
	
	/// <summary>
	/// Returns all TMSContactUs objects.
	/// </summary>
	/// <returns>List of all TMSContactUs objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSContactUs[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

