/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 25/07/2015 04:17:54 PM                                    */
/*                                                                          */
/* www.CodeAuthor.org                                                       */
/****************************************************************************/
/*************************************************/
/* [dbo].gspTMSFeesSetup_INSERT */
/*************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].gspTMSFeesSetup_INSERT') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].gspTMSFeesSetup_INSERT
GO

CREATE PROCEDURE [dbo].gspTMSFeesSetup_INSERT
(
@schoolCategoryID AS int = null,
@feesCategoryID AS int = null,
@feesTermID AS bigint = null,
@feesHeadID AS int = null,
@studentTypeID AS int = null,
@feesAmount AS decimal = null,
@createdDate AS datetime = null,
@isDelete AS bit = null
)
AS

INSERT INTO
  [dbo].[TMS_FeesSetup]
(
  [SchoolCategoryID],
  [FeesCategoryID],
  [FeesTermID],
  [FeesHeadID],
  [StudentTypeID],
  [FeesAmount],
  [CreatedDate],
  [IsDelete]
)
VALUES
(
  @schoolCategoryID,
  @feesCategoryID,
  @feesTermID,
  @feesHeadID,
  @studentTypeID,
  @feesAmount,
  @createdDate,
  @isDelete
)

SELECT SCOPE_IDENTITY()

GO

/*************************************************/
/* [dbo].gspTMSFeesSetup_SELECT */
/*************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].gspTMSFeesSetup_SELECT') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].gspTMSFeesSetup_SELECT
GO

CREATE PROCEDURE [dbo].gspTMSFeesSetup_SELECT
(
@feesSetupID AS bigint
)
AS

SELECT
  *
FROM
  [dbo].[TMS_FeesSetup]
WHERE
  FeesSetupID = @feesSetupID

GO

/*************************************************/
/* [dbo].gspTMSFeesSetup_UPDATE */
/*************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].gspTMSFeesSetup_UPDATE') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].gspTMSFeesSetup_UPDATE
GO

CREATE PROCEDURE [dbo].gspTMSFeesSetup_UPDATE
(
@feesSetupID bigint = null,
@schoolCategoryID int = null,
@feesCategoryID int = null,
@feesTermID bigint = null,
@feesHeadID int = null,
@studentTypeID int = null,
@feesAmount decimal = null,
@createdDate datetime = null,
@isDelete bit = null
)
AS

UPDATE
  [dbo].[TMS_FeesSetup]
SET
  [SchoolCategoryID] = @schoolCategoryID,
  [FeesCategoryID] = @feesCategoryID,
  [FeesTermID] = @feesTermID,
  [FeesHeadID] = @feesHeadID,
  [StudentTypeID] = @studentTypeID,
  [FeesAmount] = @feesAmount,
  [CreatedDate] = @createdDate,
  [IsDelete] = @isDelete
WHERE
  [FeesSetupID] = @feesSetupID

GO

/*************************************************/
/* [dbo].gspTMSFeesSetup_DELETE */
/*************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].gspTMSFeesSetup_DELETE') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].gspTMSFeesSetup_DELETE
GO

CREATE PROCEDURE [dbo].gspTMSFeesSetup_DELETE
(
@feesSetupID bigint
)
AS

DELETE
  [dbo].[TMS_FeesSetup]
WHERE
  [FeesSetupID] = @feesSetupID

GO

/*************************************************/
/* [dbo].gspTMSFeesSetup_SEARCH */
/*************************************************/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].gspTMSFeesSetup_SEARCH') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].gspTMSFeesSetup_SEARCH
GO

CREATE PROCEDURE [dbo].gspTMSFeesSetup_SEARCH
(
@feesSetupID bigint = null,
@schoolCategoryID int = null,
@feesCategoryID int = null,
@feesTermID bigint = null,
@feesHeadID int = null,
@studentTypeID int = null,
@feesAmount decimal = null,
@createdDate datetime = null,
@isDelete bit = null
)
AS

SELECT
  *
FROM
  [dbo].[TMS_FeesSetup]
WHERE
  (@feesSetupID IS NULL OR [FeesSetupID] = @feesSetupID)
AND
  (@schoolCategoryID IS NULL OR [SchoolCategoryID] = @schoolCategoryID)
AND
  (@feesCategoryID IS NULL OR [FeesCategoryID] = @feesCategoryID)
AND
  (@feesTermID IS NULL OR [FeesTermID] = @feesTermID)
AND
  (@feesHeadID IS NULL OR [FeesHeadID] = @feesHeadID)
AND
  (@studentTypeID IS NULL OR [StudentTypeID] = @studentTypeID)
AND
  (@feesAmount IS NULL OR [FeesAmount] = @feesAmount)
AND
  (@createdDate IS NULL OR [CreatedDate] = @createdDate)
AND
  (@isDelete IS NULL OR [IsDelete] = @isDelete)

GO

