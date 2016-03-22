
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/21/2016 14:14:42
-- Generated from EDMX file: C:\Users\Miryame\documents\visual studio 2015\Projects\Projet AGA\AGA.Data\AGADataBase.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AGASQLIDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DemandeSet'
CREATE TABLE [dbo].[DemandeSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [dateCreation] datetime  NOT NULL,
    [dateDebutTraitement] datetime  NULL,
    [dateFinTraitement] datetime  NULL,
    [TypeAttestation_id] int  NOT NULL,
    [Collaborateur_id] int  NOT NULL,
    [Statut_id] int  NOT NULL,
    [Assistante_id] int  NOT NULL,
    [EmailContenu_id] int  NOT NULL
);
GO

-- Creating table 'TypeAttestationSet'
CREATE TABLE [dbo].[TypeAttestationSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [code] nvarchar(max)  NOT NULL,
    [label] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StatutSet'
CREATE TABLE [dbo].[StatutSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [code] nvarchar(max)  NOT NULL,
    [label] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CollaborateurSet'
CREATE TABLE [dbo].[CollaborateurSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nom] nvarchar(max)  NOT NULL,
    [prenom] nvarchar(max)  NOT NULL,
    [cin] nvarchar(max)  NULL,
    [cnss] nvarchar(max)  NULL,
    [poste] nvarchar(max)  NULL,
    [dateDebutTravail] datetime  NULL,
    [banque] nvarchar(max)  NULL,
    [isEligible] bit  NOT NULL
);
GO

-- Creating table 'AttestationCongeSet'
CREATE TABLE [dbo].[AttestationCongeSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [dateDebut] nvarchar(max)  NOT NULL,
    [dateFin] nvarchar(max)  NOT NULL,
    [Demande_id] int  NOT NULL
);
GO

-- Creating table 'NotificationEmailSet'
CREATE TABLE [dbo].[NotificationEmailSet] (
    [id] int IDENTITY(1,1) NOT NULL,
    [objet] nvarchar(max)  NOT NULL,
    [contenu] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'DemandeSet'
ALTER TABLE [dbo].[DemandeSet]
ADD CONSTRAINT [PK_DemandeSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'TypeAttestationSet'
ALTER TABLE [dbo].[TypeAttestationSet]
ADD CONSTRAINT [PK_TypeAttestationSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'StatutSet'
ALTER TABLE [dbo].[StatutSet]
ADD CONSTRAINT [PK_StatutSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'CollaborateurSet'
ALTER TABLE [dbo].[CollaborateurSet]
ADD CONSTRAINT [PK_CollaborateurSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'AttestationCongeSet'
ALTER TABLE [dbo].[AttestationCongeSet]
ADD CONSTRAINT [PK_AttestationCongeSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'NotificationEmailSet'
ALTER TABLE [dbo].[NotificationEmailSet]
ADD CONSTRAINT [PK_NotificationEmailSet]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TypeAttestation_id] in table 'DemandeSet'
ALTER TABLE [dbo].[DemandeSet]
ADD CONSTRAINT [FK_DemandeTypeAttestation]
    FOREIGN KEY ([TypeAttestation_id])
    REFERENCES [dbo].[TypeAttestationSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DemandeTypeAttestation'
CREATE INDEX [IX_FK_DemandeTypeAttestation]
ON [dbo].[DemandeSet]
    ([TypeAttestation_id]);
GO

-- Creating foreign key on [Demande_id] in table 'AttestationCongeSet'
ALTER TABLE [dbo].[AttestationCongeSet]
ADD CONSTRAINT [FK_AttestationCongeDemande]
    FOREIGN KEY ([Demande_id])
    REFERENCES [dbo].[DemandeSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AttestationCongeDemande'
CREATE INDEX [IX_FK_AttestationCongeDemande]
ON [dbo].[AttestationCongeSet]
    ([Demande_id]);
GO

-- Creating foreign key on [Collaborateur_id] in table 'DemandeSet'
ALTER TABLE [dbo].[DemandeSet]
ADD CONSTRAINT [FK_CollaborateurDemande]
    FOREIGN KEY ([Collaborateur_id])
    REFERENCES [dbo].[CollaborateurSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CollaborateurDemande'
CREATE INDEX [IX_FK_CollaborateurDemande]
ON [dbo].[DemandeSet]
    ([Collaborateur_id]);
GO

-- Creating foreign key on [Statut_id] in table 'DemandeSet'
ALTER TABLE [dbo].[DemandeSet]
ADD CONSTRAINT [FK_DemandeStatut]
    FOREIGN KEY ([Statut_id])
    REFERENCES [dbo].[StatutSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DemandeStatut'
CREATE INDEX [IX_FK_DemandeStatut]
ON [dbo].[DemandeSet]
    ([Statut_id]);
GO

-- Creating foreign key on [Assistante_id] in table 'DemandeSet'
ALTER TABLE [dbo].[DemandeSet]
ADD CONSTRAINT [FK_CollaborateurAssistante]
    FOREIGN KEY ([Assistante_id])
    REFERENCES [dbo].[CollaborateurSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CollaborateurAssistante'
CREATE INDEX [IX_FK_CollaborateurAssistante]
ON [dbo].[DemandeSet]
    ([Assistante_id]);
GO

-- Creating foreign key on [EmailContenu_id] in table 'DemandeSet'
ALTER TABLE [dbo].[DemandeSet]
ADD CONSTRAINT [FK_EmailContenuDemande]
    FOREIGN KEY ([EmailContenu_id])
    REFERENCES [dbo].[NotificationEmailSet]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmailContenuDemande'
CREATE INDEX [IX_FK_EmailContenuDemande]
ON [dbo].[DemandeSet]
    ([EmailContenu_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------