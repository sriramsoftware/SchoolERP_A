using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSCoScholasticSkillType
{
    #region GetSEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? stSkillId, System.Int64? stSchoolId, System.String stSkillName, System.String stSkillDescription, System.String stExtra, System.DateTime? stDate, System.Int32? stStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSCoScholasticSkillType_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, stSkillId, stSchoolId, stSkillName, stSkillDescription, stExtra, stDate, stStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet GetSearch(TMSCoScholasticSkillType searchObject)
    {
        return GetSearch(searchObject.STSkillId, searchObject.STSchoolId, searchObject.STSkillName, searchObject.STSkillDescription, searchObject.STExtra, searchObject.STDate, searchObject.STStatus);
    }

    /// <summary>
    /// Returns all TMSCoScholasticSkillType objects.
    /// </summary>
    /// <returns>List of all TMSCoScholasticSkillType objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null);
    }


    public static DataSet GetSkillType(System.Int64? stSkillId, System.Int64? stSchoolId, System.String stSkillName)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSGetCo_Scholastic";
        dbCommand = db.GetStoredProcCommand(sqlCommand, stSkillId, stSchoolId, stSkillName);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;  
    }

    #endregion
}

