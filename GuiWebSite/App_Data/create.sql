SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL';

CREATE SCHEMA IF NOT EXISTS `colegioDB` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci ;
USE `colegioDB`;

-- -----------------------------------------------------
-- Table `colegioDB`.`Perfil`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`Perfil` (
  `Id` INT NOT NULL AUTO_INCREMENT ,
  `Descricao` VARCHAR(45) NOT NULL ,
  `Status` BOOLEAN NULL ,
  `CtrlAluno` INT NULL ,
  `CtrlFuncionario` INT NULL ,
  `CtrlTurma` INT NULL ,
  `CtrlSerie` INT NULL ,
  `CtrlTurno` INT NULL ,
  `CtrlRemanejamento` INT NULL ,
  `CtrlNotas` INT NULL ,
  `CtrlMensalidade` INT NULL ,
  `CtrlAtividade` INT NULL ,
  `CtrlContasPagar` INT NULL ,
  `CtrlFinanceiro` INT NULL ,
  `CtrlCheques` INT NULL ,
  `CtrlTransfHistoricos` INT NULL ,
  `CtrlCertificados` INT NULL ,
  `CtrlAniversariantes` INT NULL ,
  `CtrlDeclaracaoQuitacao` INT NULL ,
  `CtrlFolhaPonto` INT NULL ,
  `CtrlFreqFuncionarios` INT NULL ,
  `CtrlEmails` INT NULL ,
  `CtrlFreqAlunos` INT NULL ,
  `CtrlRankingNotas` INT NULL ,
  `CtrlAdvertenciasAtrasos` INT NULL ,
  `CtrlBoletim` INT NULL ,
  `CtrlGRE` INT NULL ,
  `CtrlAnotacoes` INT NULL ,
  `CtrlFolhaChamada` INT NULL ,
  `CtrlDebitos` INT NULL ,
  PRIMARY KEY (`Id`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `colegioDB`.`Aluno`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`Aluno` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nome` VARCHAR(50) NOT NULL ,
  `Imagem` LONGBLOB NULL ,
  `Nascimento` DATETIME NULL ,
  `Sexo` BOOLEAN NULL ,
  `Naturalidade` VARCHAR(30) NULL ,
  `Nacionalidade` VARCHAR(30) NULL ,
  `FoneResidencia` VARCHAR(14) NULL ,
  `FoneAluno` VARCHAR(14) NULL ,
  `FoneMedico` VARCHAR(14) NULL ,
  `FoneEmergencia` VARCHAR(14) NULL ,
  `Alergico` VARCHAR(100) NULL ,
  `GrupoSanguineo` VARCHAR(3) NULL ,
  `FatorRh` BOOLEAN NULL ,
  `NomeMedico` VARCHAR(50) NULL ,
  `Hospital` VARCHAR(30) NULL ,
  `PlanoSaude` VARCHAR(30) NULL ,
  `DescricaoMedica` VARCHAR(300) NULL ,
  `Email` VARCHAR(40) NULL ,
  `SituacaoEspecial` VARCHAR(300) NULL ,
  `Logradouro` VARCHAR(60) NULL ,
  `Bairro` VARCHAR(30) NULL ,
  `Cidade` VARCHAR(30) NULL ,
  `Cep` VARCHAR(9) NULL ,
  `Uf` VARCHAR(2) NULL ,
  `ComplementoEndereco` VARCHAR(30) NULL ,
  `Status` BOOLEAN NULL ,
  `Login` VARCHAR(30) NULL ,
  `Senha` VARCHAR(20) NULL ,
  `ContatoNome` VARCHAR(45) NULL ,
  `ContatoTelefone` VARCHAR(45) NULL ,
  `PerfilId` INT NOT NULL ,
  `Edificio` VARCHAR(45) NULL ,
  PRIMARY KEY (`Id`) ,
  INDEX `fk_Aluno_Perfil` (`PerfilId` ASC) ,
  CONSTRAINT `fk_Aluno_Perfil`
    FOREIGN KEY (`PerfilId` )
    REFERENCES `colegioDB`.`Perfil` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
PACK_KEYS = 0
ROW_FORMAT = DEFAULT;


-- -----------------------------------------------------
-- Table `colegioDB`.`Desconto`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`Desconto` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Descricao` VARCHAR(30) NOT NULL ,
  `Percentual` DOUBLE NOT NULL ,
  `Status` BOOLEAN NULL ,
  PRIMARY KEY (`Id`) )
PACK_KEYS = 0
ROW_FORMAT = DEFAULT;


-- -----------------------------------------------------
-- Table `colegioDB`.`Responsavel`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`Responsavel` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nome` VARCHAR(50) NOT NULL ,
  `Imagem` LONGBLOB NULL ,
  `Fone` VARCHAR(14) NULL ,
  `Email` VARCHAR(40) NULL ,
  `Cpf` VARCHAR(11) NULL ,
  `Rg` VARCHAR(20) NULL ,
  `Nascimento` DATETIME NULL ,
  `Profissao` VARCHAR(30) NULL ,
  `FoneTrabalho` VARCHAR(14) NULL ,
  `LocalTrabalho` VARCHAR(30) NULL ,
  `Logradouro` VARCHAR(60) NULL ,
  `Bairro` VARCHAR(30) NULL ,
  `Cidade` VARCHAR(30) NULL ,
  `Cep` VARCHAR(9) NULL ,
  `Uf` VARCHAR(2) NULL ,
  `ComplementoEndereco` VARCHAR(30) NULL ,
  `Status` BOOLEAN NULL ,
  `Sexo` BOOLEAN NULL ,
  `Login` VARCHAR(30) NULL ,
  `Senha` VARCHAR(20) NULL ,
  `PerfilId` INT NULL ,
  `Edificio` VARCHAR(45) NULL ,
  PRIMARY KEY (`Id`) ,
  INDEX `fk_Responsavel_Perfil` (`PerfilId` ASC) ,
  CONSTRAINT `fk_Responsavel_Perfil`
    FOREIGN KEY (`PerfilId` )
    REFERENCES `colegioDB`.`Perfil` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
PACK_KEYS = 0
ROW_FORMAT = DEFAULT;


-- -----------------------------------------------------
-- Table `colegioDB`.`Serie`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`Serie` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nome` VARCHAR(30) NULL ,
  `Status` BOOLEAN NULL ,
  `Valor` DOUBLE NULL ,
  `Ciclo` VARCHAR(45) NULL ,
  PRIMARY KEY (`Id`) )
PACK_KEYS = 0
ROW_FORMAT = DEFAULT;


-- -----------------------------------------------------
-- Table `colegioDB`.`Turma`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`Turma` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nome` VARCHAR(50) NULL ,
  `Status` BOOLEAN NULL ,
  PRIMARY KEY (`Id`) )
PACK_KEYS = 0
ROW_FORMAT = DEFAULT;


-- -----------------------------------------------------
-- Table `colegioDB`.`Turno`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`Turno` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nome` VARCHAR(30) NULL ,
  `Status` BOOLEAN NULL ,
  PRIMARY KEY (`Id`) )
PACK_KEYS = 0
ROW_FORMAT = DEFAULT;


-- -----------------------------------------------------
-- Table `colegioDB`.`Disciplina`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`Disciplina` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nome` VARCHAR(50) NULL ,
  `Status` BOOLEAN NULL ,
  `TipoAvaliacao` BOOLEAN NULL ,
  PRIMARY KEY (`Id`) )
PACK_KEYS = 0
ROW_FORMAT = DEFAULT;


-- -----------------------------------------------------
-- Table `colegioDB`.`Funcionario`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`Funcionario` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nome` VARCHAR(50) NOT NULL ,
  `Sexo` BOOLEAN NULL ,
  `Nascimento` DATETIME NULL ,
  `Emisor` VARCHAR(30) NULL ,
  `Cpf` VARCHAR(11) NULL ,
  `Pis` VARCHAR(45) NULL ,
  `Ctps` VARCHAR(30) NULL ,
  `Serie` VARCHAR(30) NULL ,
  `DataEfetivacao` DATETIME NULL ,
  `Naturalidade` VARCHAR(30) NULL ,
  `Filiacao` VARCHAR(50) NULL ,
  `Imagem` LONGBLOB NULL ,
  `Cargo` VARCHAR(100) NULL ,
  `FoneEmergencia` VARCHAR(14) NULL ,
  `ContatoEmergencia` VARCHAR(50) NULL ,
  `Alergico` VARCHAR(100) NULL ,
  `Logradouro` VARCHAR(60) NULL ,
  `Bairro` VARCHAR(30) NULL ,
  `Cidade` VARCHAR(30) NULL ,
  `Cep` VARCHAR(9) NULL ,
  `Uf` VARCHAR(2) NULL ,
  `ComplementoEndereco` VARCHAR(30) NULL ,
  `Status` BOOLEAN NULL ,
  `Login` VARCHAR(30) NULL ,
  `Senha` VARCHAR(20) NULL ,
  `Email` VARCHAR(40) NULL ,
  `PerfilId` INT NULL ,
  `Edificio` VARCHAR(45) NULL ,
  PRIMARY KEY (`Id`) ,
  INDEX `fk_Funcionario_Perfil` (`PerfilId` ASC) ,
  CONSTRAINT `fk_Funcionario_Perfil`
    FOREIGN KEY (`PerfilId` )
    REFERENCES `colegioDB`.`Perfil` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
PACK_KEYS = 0
ROW_FORMAT = DEFAULT;


-- -----------------------------------------------------
-- Table `colegioDB`.`Atividade`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`Atividade` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Nome` VARCHAR(50) NULL ,
  `Descricao` VARCHAR(100) NULL ,
  `Imagem` LONGBLOB NULL ,
  `Valor` DOUBLE NULL ,
  `Status` BOOLEAN NULL ,
  `FuncionarioId` INT UNSIGNED NULL ,
  PRIMARY KEY (`Id`) ,
  INDEX `fk_Atividade_Funcionario` (`FuncionarioId` ASC) ,
  CONSTRAINT `fk_Atividade_Funcionario`
    FOREIGN KEY (`FuncionarioId` )
    REFERENCES `colegioDB`.`Funcionario` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
PACK_KEYS = 0
ROW_FORMAT = DEFAULT;


-- -----------------------------------------------------
-- Table `colegioDB`.`ResponsavelAluno`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`ResponsavelAluno` (
  `GrauParentescoId` INT UNSIGNED NOT NULL ,
  `Restricoes` VARCHAR(300) NULL ,
  `Status` BOOLEAN NULL ,
  `ResideCom` BOOLEAN NULL ,
  `ResponsavelId` INT UNSIGNED NOT NULL ,
  `AlunoId` INT UNSIGNED NOT NULL ,
  `Id` INT NOT NULL AUTO_INCREMENT ,
  INDEX `ResponsavelAluno_FKIndex3` (`GrauParentescoId` ASC) ,
  INDEX `fk_ResponsavelAluno_Responsavel` (`ResponsavelId` ASC) ,
  INDEX `fk_ResponsavelAluno_Aluno` (`AlunoId` ASC) ,
  PRIMARY KEY (`Id`) ,
  CONSTRAINT `fk_ResponsavelAluno_Responsavel`
    FOREIGN KEY (`ResponsavelId` )
    REFERENCES `colegioDB`.`Responsavel` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ResponsavelAluno_Aluno`
    FOREIGN KEY (`AlunoId` )
    REFERENCES `colegioDB`.`Aluno` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
PACK_KEYS = 0
ROW_FORMAT = DEFAULT;


-- -----------------------------------------------------
-- Table `colegioDB`.`Sala`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`Sala` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Status` BOOLEAN NULL ,
  `TurmaId` INT UNSIGNED NULL ,
  `SerieId` INT UNSIGNED NULL ,
  `TurnoId` INT UNSIGNED NULL ,
  PRIMARY KEY (`Id`) ,
  INDEX `fk_Sala_Turma` (`TurmaId` ASC) ,
  INDEX `fk_Sala_Serie` (`SerieId` ASC) ,
  INDEX `fk_Sala_Turno` (`TurnoId` ASC) ,
  CONSTRAINT `fk_Sala_Turma`
    FOREIGN KEY (`TurmaId` )
    REFERENCES `colegioDB`.`Turma` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Sala_Serie`
    FOREIGN KEY (`SerieId` )
    REFERENCES `colegioDB`.`Serie` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Sala_Turno`
    FOREIGN KEY (`TurnoId` )
    REFERENCES `colegioDB`.`Turno` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
PACK_KEYS = 0
ROW_FORMAT = DEFAULT;


-- -----------------------------------------------------
-- Table `colegioDB`.`SalaPeriodo`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`SalaPeriodo` (
  `Id` INT NOT NULL AUTO_INCREMENT ,
  `Ano` INT NULL ,
  `SalaId` INT UNSIGNED NULL ,
  `Status` BOOLEAN NULL ,
  PRIMARY KEY (`Id`) ,
  INDEX `fk_SalaPeriodo_Sala` (`SalaId` ASC) ,
  CONSTRAINT `fk_SalaPeriodo_Sala`
    FOREIGN KEY (`SalaId` )
    REFERENCES `colegioDB`.`Sala` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `colegioDB`.`ProfessorDisciplinaSala`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`ProfessorDisciplinaSala` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT ,
  `DataPeriodo` DATETIME NULL ,
  `Status` BOOLEAN NULL ,
  `SalaPeriodoId` INT NULL ,
  `DisciplinaId` INT UNSIGNED NULL ,
  `FuncionarioId` INT UNSIGNED NULL ,
  PRIMARY KEY (`Id`) ,
  INDEX `fk_ProfessorDisciplinaSala_SalaPeriodo` (`SalaPeriodoId` ASC) ,
  INDEX `fk_ProfessorDisciplinaSala_Disciplina` (`DisciplinaId` ASC) ,
  INDEX `fk_ProfessorDisciplinaSala_Funcionario` (`FuncionarioId` ASC) ,
  CONSTRAINT `fk_ProfessorDisciplinaSala_SalaPeriodo`
    FOREIGN KEY (`SalaPeriodoId` )
    REFERENCES `colegioDB`.`SalaPeriodo` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ProfessorDisciplinaSala_Disciplina`
    FOREIGN KEY (`DisciplinaId` )
    REFERENCES `colegioDB`.`Disciplina` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ProfessorDisciplinaSala_Funcionario`
    FOREIGN KEY (`FuncionarioId` )
    REFERENCES `colegioDB`.`Funcionario` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
PACK_KEYS = 0
ROW_FORMAT = DEFAULT;


-- -----------------------------------------------------
-- Table `colegioDB`.`AlunoAtividade`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`AlunoAtividade` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Status` BOOLEAN NULL ,
  `AlunoId` INT UNSIGNED NULL ,
  `DescontoId` INT UNSIGNED NULL ,
  `AtividadeId` INT UNSIGNED NULL ,
  PRIMARY KEY (`Id`) ,
  INDEX `fk_AlunoAtividade_Aluno` (`AlunoId` ASC) ,
  INDEX `fk_AlunoAtividade_Desconto` (`DescontoId` ASC) ,
  INDEX `fk_AlunoAtividade_Atividade` (`AtividadeId` ASC) ,
  CONSTRAINT `fk_AlunoAtividade_Aluno`
    FOREIGN KEY (`AlunoId` )
    REFERENCES `colegioDB`.`Aluno` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_AlunoAtividade_Desconto`
    FOREIGN KEY (`DescontoId` )
    REFERENCES `colegioDB`.`Desconto` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_AlunoAtividade_Atividade`
    FOREIGN KEY (`AtividadeId` )
    REFERENCES `colegioDB`.`Atividade` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
PACK_KEYS = 0
ROW_FORMAT = DEFAULT;


-- -----------------------------------------------------
-- Table `colegioDB`.`Matricula`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`Matricula` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT ,
  `DataMatricula` DATETIME NULL ,
  `Status` BOOLEAN NULL ,
  `Valor` DOUBLE NULL ,
  `NumMatricula` VARCHAR(30) NOT NULL ,
  `AlunoId` INT UNSIGNED NULL ,
  `DescontoId` INT UNSIGNED NULL ,
  `SalaPeriodoId` INT NULL ,
  PRIMARY KEY (`Id`) ,
  INDEX `fk_Matricula_Aluno` (`AlunoId` ASC) ,
  INDEX `fk_Matricula_Desconto` (`DescontoId` ASC) ,
  INDEX `fk_Matricula_SalaPeriodo` (`SalaPeriodoId` ASC) ,
  CONSTRAINT `fk_Matricula_Aluno`
    FOREIGN KEY (`AlunoId` )
    REFERENCES `colegioDB`.`Aluno` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Matricula_Desconto`
    FOREIGN KEY (`DescontoId` )
    REFERENCES `colegioDB`.`Desconto` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Matricula_SalaPeriodo`
    FOREIGN KEY (`SalaPeriodoId` )
    REFERENCES `colegioDB`.`SalaPeriodo` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
PACK_KEYS = 0
ROW_FORMAT = DEFAULT;


-- -----------------------------------------------------
-- Table `colegioDB`.`Nota`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`Nota` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Vp` DOUBLE UNSIGNED NULL ,
  `Vc1` DOUBLE UNSIGNED NOT NULL ,
  `Vc2` DOUBLE NOT NULL ,
  `Rec` DOUBLE NULL ,
  `RecFinal` DOUBLE NULL ,
  `Aprovado` BOOLEAN NULL ,
  `ProfessorDisciplinaSalaId` INT UNSIGNED NULL ,
  `MatriculaId` INT UNSIGNED NULL ,
  `Status` BOOLEAN NULL ,
  PRIMARY KEY (`Id`) ,
  INDEX `fk_Nota_ProfessorDisciplinaSala` (`ProfessorDisciplinaSalaId` ASC) ,
  INDEX `fk_Nota_Matricula` (`MatriculaId` ASC) ,
  CONSTRAINT `fk_Nota_ProfessorDisciplinaSala`
    FOREIGN KEY (`ProfessorDisciplinaSalaId` )
    REFERENCES `colegioDB`.`ProfessorDisciplinaSala` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Nota_Matricula`
    FOREIGN KEY (`MatriculaId` )
    REFERENCES `colegioDB`.`Matricula` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
PACK_KEYS = 0
ROW_FORMAT = DEFAULT;


-- -----------------------------------------------------
-- Table `colegioDB`.`AtividadeData`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`AtividadeData` (
  `Id` INT NOT NULL ,
  `HoraInicio` TIME NULL ,
  `HoraFim` TIME NULL ,
  `DiaSemana` DATE NULL ,
  `Status` BOOLEAN NULL ,
  `AtividadeId` INT UNSIGNED NULL ,
  PRIMARY KEY (`Id`) ,
  INDEX `fk_AtividadeData_Atividade` (`AtividadeId` ASC) ,
  CONSTRAINT `fk_AtividadeData_Atividade`
    FOREIGN KEY (`AtividadeId` )
    REFERENCES `colegioDB`.`Atividade` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `colegioDB`.`BoletoMensalidade`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`BoletoMensalidade` (
  `Id` INT NOT NULL AUTO_INCREMENT ,
  `Descricao` VARCHAR(45) NOT NULL ,
  `DataVencimento` DATETIME NOT NULL ,
  `DataPagamento` DATETIME NULL ,
  `Status` BOOLEAN NULL ,
  `Desconto` DOUBLE NULL ,
  `Multa` DOUBLE NULL ,
  `Parcela` INT NULL ,
  `MatriculaId` INT UNSIGNED NULL ,
  `DataEmissao` DATETIME NOT NULL ,
  PRIMARY KEY (`Id`) ,
  INDEX `fk_BoletoMensalidade_Matricula` (`MatriculaId` ASC) ,
  CONSTRAINT `fk_BoletoMensalidade_Matricula`
    FOREIGN KEY (`MatriculaId` )
    REFERENCES `colegioDB`.`Matricula` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `colegioDB`.`BoletoAtividade`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`BoletoAtividade` (
  `Id` INT NOT NULL AUTO_INCREMENT ,
  `Descricao` VARCHAR(45) NOT NULL ,
  `DataVencimento` DATETIME NOT NULL ,
  `DataPagamento` DATETIME NULL ,
  `Status` BOOLEAN NULL ,
  `Desconto` DOUBLE NULL ,
  `Multa` DOUBLE NULL ,
  `Parcela` INT NULL ,
  `MatriculaId` INT UNSIGNED NULL ,
  `DataEmissao` DATETIME NOT NULL ,
  PRIMARY KEY (`Id`) ,
  INDEX `fk_BoletoAtividade_Matricula` (`MatriculaId` ASC) ,
  CONSTRAINT `fk_BoletoAtividade_Matricula`
    FOREIGN KEY (`MatriculaId` )
    REFERENCES `colegioDB`.`Matricula` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `colegioDB`.`ContasAPagar`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`ContasAPagar` (
  `Id` INT NOT NULL AUTO_INCREMENT ,
  `Descricao` VARCHAR(100) NOT NULL ,
  `DataVencimento` DATETIME NOT NULL ,
  `DataPagamento` DATETIME NULL ,
  `Status` BOOLEAN NULL ,
  `Desconto` DOUBLE NULL ,
  `Multa` DOUBLE NULL ,
  `Valor` DOUBLE NULL ,
  `Parcela` INT NULL ,
  PRIMARY KEY (`Id`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `colegioDB`.`Cheque`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`Cheque` (
  `Id` INT NOT NULL AUTO_INCREMENT ,
  `Banco` VARCHAR(45) NULL ,
  `Agencia` VARCHAR(50) NULL ,
  `Conta` VARCHAR(45) NULL ,
  `Valor` DOUBLE NULL ,
  `Parcela` INT NULL ,
  `NumCheque` INT NULL ,
  `Tipo` INT NOT NULL ,
  `Cpf` VARCHAR(11) NOT NULL ,
  `Status` BOOLEAN NULL ,
  PRIMARY KEY (`Id`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `colegioDB`.`Dependencia`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`Dependencia` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT ,
  `Vp` DOUBLE UNSIGNED NULL ,
  `Vc1` DOUBLE UNSIGNED NOT NULL ,
  `Vc2` DOUBLE NOT NULL ,
  `Rec` DOUBLE NULL ,
  `RecFinal` DOUBLE NULL ,
  `Aprovado` BOOLEAN NULL ,
  `ProfessorDisciplinaSalaId` INT UNSIGNED NULL ,
  `Status` BOOLEAN NULL ,
  PRIMARY KEY (`Id`) ,
  INDEX `fk_Dependencia_ProfessorDisciplinaSala` (`ProfessorDisciplinaSalaId` ASC) ,
  CONSTRAINT `fk_Dependencia_ProfessorDisciplinaSala`
    FOREIGN KEY (`ProfessorDisciplinaSalaId` )
    REFERENCES `colegioDB`.`ProfessorDisciplinaSala` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
PACK_KEYS = 0
ROW_FORMAT = DEFAULT;


-- -----------------------------------------------------
-- Table `colegioDB`.`ChequeBoletoMensalidade`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`ChequeBoletoMensalidade` (
  `ChequeId` INT NOT NULL ,
  `BoletoMensalidadeId` INT NOT NULL ,
  `Status` BOOLEAN NULL ,
  `Id` INT NOT NULL AUTO_INCREMENT ,
  INDEX `fk_Cheque_has_BoletoMensalidade_Cheque` (`ChequeId` ASC) ,
  INDEX `fk_Cheque_has_BoletoMensalidade_BoletoMensalidade` (`BoletoMensalidadeId` ASC) ,
  PRIMARY KEY (`Id`) ,
  CONSTRAINT `fk_Cheque_has_BoletoMensalidade_Cheque`
    FOREIGN KEY (`ChequeId` )
    REFERENCES `colegioDB`.`Cheque` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Cheque_has_BoletoMensalidade_BoletoMensalidade`
    FOREIGN KEY (`BoletoMensalidadeId` )
    REFERENCES `colegioDB`.`BoletoMensalidade` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Table `colegioDB`.`ChequeBoletoAtividade`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `colegioDB`.`ChequeBoletoAtividade` (
  `BoletoAtividadeId` INT NOT NULL ,
  `ChequeId` INT NOT NULL ,
  `Status` BOOLEAN NULL ,
  `Id` INT NOT NULL AUTO_INCREMENT ,
  PRIMARY KEY (`Id`) ,
  INDEX `fk_BoletoAtividade_has_Cheque_BoletoAtividade` (`BoletoAtividadeId` ASC) ,
  INDEX `fk_BoletoAtividade_has_Cheque_Cheque` (`ChequeId` ASC) ,
  CONSTRAINT `fk_BoletoAtividade_has_Cheque_BoletoAtividade`
    FOREIGN KEY (`BoletoAtividadeId` )
    REFERENCES `colegioDB`.`BoletoAtividade` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_BoletoAtividade_has_Cheque_Cheque`
    FOREIGN KEY (`ChequeId` )
    REFERENCES `colegioDB`.`Cheque` (`Id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
