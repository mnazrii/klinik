CREATE TABLE [dbo].[q_documents] (
    [q_id]    INT            NOT NULL,
    [mc_name] NVARCHAR (30)  NOT NULL,
    [value_]  NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_q_documents] PRIMARY KEY CLUSTERED ([mc_name] ASC, [q_id] ASC)
);

