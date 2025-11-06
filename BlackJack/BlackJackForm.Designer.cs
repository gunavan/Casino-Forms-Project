using System;

namespace Casino_Forms_Project
{
    partial class BlackJackForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJackForm));
            this.playerMoneyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.tenButton = new System.Windows.Forms.Button();
            this.twfivButton = new System.Windows.Forms.Button();
            this.hundButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playerBalanceLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.currentBetLabel = new System.Windows.Forms.Label();
            this.clearBetButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.playerExpandedHand = new System.Windows.Forms.Label();
            this.dealerExpandedHand = new System.Windows.Forms.Label();
            this.crLabel = new System.Windows.Forms.Label();
            this.cardsRemainingLabel = new System.Windows.Forms.Label();
            this.playerHandLabel = new System.Windows.Forms.Label();
            this.dealerHandLabel = new System.Windows.Forms.Label();
            this.winloseLabel = new System.Windows.Forms.Label();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.shuffleLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shuffleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeckMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDeckMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshScreenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerHandMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCard1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCard2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pNewCardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealerHandMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dCard1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dCard2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dNewCardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experimentalButton = new System.Windows.Forms.Button();
            this.allInButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerMoneyLabel
            // 
            this.playerMoneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerMoneyLabel.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerMoneyLabel.Location = new System.Drawing.Point(317, 28);
            this.playerMoneyLabel.Name = "playerMoneyLabel";
            this.playerMoneyLabel.Size = new System.Drawing.Size(216, 37);
            this.playerMoneyLabel.TabIndex = 4;
            this.playerMoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Money in BlackJack:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // betButton
            // 
            this.betButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.betButton.Font = new System.Drawing.Font("Javanese Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betButton.Location = new System.Drawing.Point(947, 656);
            this.betButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(124, 124);
            this.betButton.TabIndex = 6;
            this.betButton.Text = "Bet";
            this.betButton.UseVisualStyleBackColor = false;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.oneButton.Font = new System.Drawing.Font("Javanese Text", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.Location = new System.Drawing.Point(221, 656);
            this.oneButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(124, 124);
            this.oneButton.TabIndex = 6;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fiveButton.Font = new System.Drawing.Font("Javanese Text", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.Location = new System.Drawing.Point(366, 656);
            this.fiveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(124, 124);
            this.fiveButton.TabIndex = 6;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // tenButton
            // 
            this.tenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tenButton.Font = new System.Drawing.Font("Javanese Text", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenButton.Location = new System.Drawing.Point(513, 656);
            this.tenButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenButton.Name = "tenButton";
            this.tenButton.Size = new System.Drawing.Size(124, 124);
            this.tenButton.TabIndex = 6;
            this.tenButton.Text = "10";
            this.tenButton.UseVisualStyleBackColor = false;
            this.tenButton.Click += new System.EventHandler(this.tenButton_Click);
            // 
            // twfivButton
            // 
            this.twfivButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.twfivButton.Font = new System.Drawing.Font("Javanese Text", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twfivButton.Location = new System.Drawing.Point(657, 656);
            this.twfivButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.twfivButton.Name = "twfivButton";
            this.twfivButton.Size = new System.Drawing.Size(124, 124);
            this.twfivButton.TabIndex = 6;
            this.twfivButton.Text = "25";
            this.twfivButton.UseVisualStyleBackColor = false;
            this.twfivButton.Click += new System.EventHandler(this.twfivButton_Click);
            // 
            // hundButton
            // 
            this.hundButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hundButton.Font = new System.Drawing.Font("Javanese Text", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hundButton.Location = new System.Drawing.Point(803, 656);
            this.hundButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hundButton.Name = "hundButton";
            this.hundButton.Size = new System.Drawing.Size(124, 124);
            this.hundButton.TabIndex = 6;
            this.hundButton.Text = "100";
            this.hundButton.UseVisualStyleBackColor = false;
            this.hundButton.Click += new System.EventHandler(this.hundButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(849, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Remaining Total Balance:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // playerBalanceLabel
            // 
            this.playerBalanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerBalanceLabel.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerBalanceLabel.Location = new System.Drawing.Point(1115, 30);
            this.playerBalanceLabel.Name = "playerBalanceLabel";
            this.playerBalanceLabel.Size = new System.Drawing.Size(149, 37);
            this.playerBalanceLabel.TabIndex = 4;
            this.playerBalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Current Bet:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currentBetLabel
            // 
            this.currentBetLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentBetLabel.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBetLabel.Location = new System.Drawing.Point(192, 615);
            this.currentBetLabel.Name = "currentBetLabel";
            this.currentBetLabel.Size = new System.Drawing.Size(171, 37);
            this.currentBetLabel.TabIndex = 4;
            this.currentBetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clearBetButton
            // 
            this.clearBetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearBetButton.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBetButton.Location = new System.Drawing.Point(75, 656);
            this.clearBetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBetButton.Name = "clearBetButton";
            this.clearBetButton.Size = new System.Drawing.Size(124, 124);
            this.clearBetButton.TabIndex = 6;
            this.clearBetButton.Text = "Clear Bet";
            this.clearBetButton.UseVisualStyleBackColor = false;
            this.clearBetButton.Click += new System.EventHandler(this.clearBetButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hitButton.Font = new System.Drawing.Font("Javanese Text", 12F);
            this.hitButton.Location = new System.Drawing.Point(990, 632);
            this.hitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(269, 71);
            this.hitButton.TabIndex = 7;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = false;
            this.hitButton.Visible = false;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.standButton.Font = new System.Drawing.Font("Javanese Text", 12F);
            this.standButton.Location = new System.Drawing.Point(990, 709);
            this.standButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(269, 71);
            this.standButton.TabIndex = 7;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = false;
            this.standButton.Visible = false;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // playerExpandedHand
            // 
            this.playerExpandedHand.BackColor = System.Drawing.Color.Transparent;
            this.playerExpandedHand.Font = new System.Drawing.Font("Javanese Text", 85.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerExpandedHand.Location = new System.Drawing.Point(12, 370);
            this.playerExpandedHand.Name = "playerExpandedHand";
            this.playerExpandedHand.Size = new System.Drawing.Size(1252, 245);
            this.playerExpandedHand.TabIndex = 8;
            this.playerExpandedHand.Text = "p hand";
            this.playerExpandedHand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.playerExpandedHand.Visible = false;
            // 
            // dealerExpandedHand
            // 
            this.dealerExpandedHand.BackColor = System.Drawing.Color.Transparent;
            this.dealerExpandedHand.Font = new System.Drawing.Font("Javanese Text", 85.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerExpandedHand.Location = new System.Drawing.Point(12, 125);
            this.dealerExpandedHand.Name = "dealerExpandedHand";
            this.dealerExpandedHand.Size = new System.Drawing.Size(1252, 245);
            this.dealerExpandedHand.TabIndex = 8;
            this.dealerExpandedHand.Text = "d hand";
            this.dealerExpandedHand.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dealerExpandedHand.Visible = false;
            // 
            // crLabel
            // 
            this.crLabel.BackColor = System.Drawing.Color.Transparent;
            this.crLabel.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crLabel.Location = new System.Drawing.Point(913, 65);
            this.crLabel.Name = "crLabel";
            this.crLabel.Size = new System.Drawing.Size(202, 37);
            this.crLabel.TabIndex = 5;
            this.crLabel.Text = "Cards Remaining:";
            this.crLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cardsRemainingLabel
            // 
            this.cardsRemainingLabel.BackColor = System.Drawing.Color.Transparent;
            this.cardsRemainingLabel.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardsRemainingLabel.Location = new System.Drawing.Point(1114, 67);
            this.cardsRemainingLabel.Name = "cardsRemainingLabel";
            this.cardsRemainingLabel.Size = new System.Drawing.Size(150, 37);
            this.cardsRemainingLabel.TabIndex = 4;
            this.cardsRemainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playerHandLabel
            // 
            this.playerHandLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerHandLabel.Font = new System.Drawing.Font("Javanese Text", 13.2F);
            this.playerHandLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playerHandLabel.Location = new System.Drawing.Point(1172, 557);
            this.playerHandLabel.Name = "playerHandLabel";
            this.playerHandLabel.Size = new System.Drawing.Size(87, 58);
            this.playerHandLabel.TabIndex = 8;
            this.playerHandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerHandLabel.Visible = false;
            // 
            // dealerHandLabel
            // 
            this.dealerHandLabel.BackColor = System.Drawing.Color.Transparent;
            this.dealerHandLabel.Font = new System.Drawing.Font("Javanese Text", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerHandLabel.Location = new System.Drawing.Point(1172, 312);
            this.dealerHandLabel.Name = "dealerHandLabel";
            this.dealerHandLabel.Size = new System.Drawing.Size(87, 58);
            this.dealerHandLabel.TabIndex = 8;
            this.dealerHandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dealerHandLabel.Visible = false;
            // 
            // winloseLabel
            // 
            this.winloseLabel.BackColor = System.Drawing.Color.Transparent;
            this.winloseLabel.Font = new System.Drawing.Font("Javanese Text", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winloseLabel.Location = new System.Drawing.Point(39, 651);
            this.winloseLabel.Name = "winloseLabel";
            this.winloseLabel.Size = new System.Drawing.Size(361, 154);
            this.winloseLabel.TabIndex = 5;
            this.winloseLabel.Text = "YOU WIN";
            this.winloseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winloseLabel.Visible = false;
            // 
            // reasonLabel
            // 
            this.reasonLabel.BackColor = System.Drawing.Color.Transparent;
            this.reasonLabel.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonLabel.Location = new System.Drawing.Point(441, 641);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(499, 154);
            this.reasonLabel.TabIndex = 5;
            this.reasonLabel.Text = "reason";
            this.reasonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reasonLabel.Visible = false;
            // 
            // shuffleLabel
            // 
            this.shuffleLabel.BackColor = System.Drawing.Color.Transparent;
            this.shuffleLabel.Font = new System.Drawing.Font("Javanese Text", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffleLabel.Location = new System.Drawing.Point(11, 312);
            this.shuffleLabel.Name = "shuffleLabel";
            this.shuffleLabel.Size = new System.Drawing.Size(1253, 123);
            this.shuffleLabel.TabIndex = 5;
            this.shuffleLabel.Text = "DECK WAS RESHUFFLED";
            this.shuffleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shuffleLabel.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1277, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shuffleMenuItem,
            this.addMenuItem,
            this.addDeckMenuItem,
            this.removeDeckMenuItem,
            this.refreshScreenMenuItem,
            this.playerHandMenuItem,
            this.dealerHandMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // shuffleMenuItem
            // 
            this.shuffleMenuItem.Name = "shuffleMenuItem";
            this.shuffleMenuItem.Size = new System.Drawing.Size(211, 26);
            this.shuffleMenuItem.Text = "Shuffle";
            this.shuffleMenuItem.Click += new System.EventHandler(this.shuffleMenuItem_Click);
            // 
            // addMenuItem
            // 
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.Size = new System.Drawing.Size(211, 26);
            this.addMenuItem.Text = "Add 500 Balance";
            this.addMenuItem.Click += new System.EventHandler(this.addMenuItem_Click);
            // 
            // addDeckMenuItem
            // 
            this.addDeckMenuItem.Name = "addDeckMenuItem";
            this.addDeckMenuItem.Size = new System.Drawing.Size(211, 26);
            this.addDeckMenuItem.Text = "Add Deck (+1)";
            this.addDeckMenuItem.Click += new System.EventHandler(this.deckQuantityMenuItem_Click);
            // 
            // removeDeckMenuItem
            // 
            this.removeDeckMenuItem.Name = "removeDeckMenuItem";
            this.removeDeckMenuItem.Size = new System.Drawing.Size(211, 26);
            this.removeDeckMenuItem.Text = "Remove Deck (-1)";
            this.removeDeckMenuItem.Click += new System.EventHandler(this.removeDeckMenuItem_Click);
            // 
            // refreshScreenMenuItem
            // 
            this.refreshScreenMenuItem.Name = "refreshScreenMenuItem";
            this.refreshScreenMenuItem.Size = new System.Drawing.Size(211, 26);
            this.refreshScreenMenuItem.Text = "Refresh Screen";
            this.refreshScreenMenuItem.Click += new System.EventHandler(this.refreshScreenMenuItem_Click);
            // 
            // playerHandMenuItem
            // 
            this.playerHandMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pCard1MenuItem,
            this.pCard2MenuItem,
            this.pNewCardMenuItem});
            this.playerHandMenuItem.Name = "playerHandMenuItem";
            this.playerHandMenuItem.Size = new System.Drawing.Size(211, 26);
            this.playerHandMenuItem.Text = "Player Hand";
            this.playerHandMenuItem.Visible = false;
            // 
            // pCard1MenuItem
            // 
            this.pCard1MenuItem.Name = "pCard1MenuItem";
            this.pCard1MenuItem.Size = new System.Drawing.Size(191, 26);
            this.pCard1MenuItem.Text = "Starting Card 1";
            this.pCard1MenuItem.Click += new System.EventHandler(this.pCard1MenuItem_Click);
            // 
            // pCard2MenuItem
            // 
            this.pCard2MenuItem.Name = "pCard2MenuItem";
            this.pCard2MenuItem.Size = new System.Drawing.Size(191, 26);
            this.pCard2MenuItem.Text = "Starting Card 2";
            this.pCard2MenuItem.Click += new System.EventHandler(this.pCard2MenuItem_Click);
            // 
            // pNewCardMenuItem
            // 
            this.pNewCardMenuItem.Name = "pNewCardMenuItem";
            this.pNewCardMenuItem.Size = new System.Drawing.Size(191, 26);
            this.pNewCardMenuItem.Text = "new Card";
            this.pNewCardMenuItem.Click += new System.EventHandler(this.pNewCardMenuItem_Click);
            // 
            // dealerHandMenuItem
            // 
            this.dealerHandMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dCard1MenuItem,
            this.dCard2MenuItem,
            this.dNewCardMenuItem});
            this.dealerHandMenuItem.Name = "dealerHandMenuItem";
            this.dealerHandMenuItem.Size = new System.Drawing.Size(211, 26);
            this.dealerHandMenuItem.Text = "Dealer Hand";
            this.dealerHandMenuItem.Visible = false;
            // 
            // dCard1MenuItem
            // 
            this.dCard1MenuItem.Name = "dCard1MenuItem";
            this.dCard1MenuItem.Size = new System.Drawing.Size(191, 26);
            this.dCard1MenuItem.Text = "Starting Card 1";
            this.dCard1MenuItem.Click += new System.EventHandler(this.dCard1MenuItem_Click);
            // 
            // dCard2MenuItem
            // 
            this.dCard2MenuItem.Name = "dCard2MenuItem";
            this.dCard2MenuItem.Size = new System.Drawing.Size(191, 26);
            this.dCard2MenuItem.Text = "Starting Card 2";
            this.dCard2MenuItem.Click += new System.EventHandler(this.dCard2MenuItem_Click);
            // 
            // dNewCardMenuItem
            // 
            this.dNewCardMenuItem.Name = "dNewCardMenuItem";
            this.dNewCardMenuItem.Size = new System.Drawing.Size(191, 26);
            this.dNewCardMenuItem.Text = "new Card";
            this.dNewCardMenuItem.Click += new System.EventHandler(this.dNewCardMenuItem_Click);
            // 
            // experimentalButton
            // 
            this.experimentalButton.BackColor = System.Drawing.Color.SeaGreen;
            this.experimentalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.experimentalButton.Font = new System.Drawing.Font("Javanese Text", 1.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experimentalButton.Location = new System.Drawing.Point(85, 6);
            this.experimentalButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.experimentalButton.Name = "experimentalButton";
            this.experimentalButton.Size = new System.Drawing.Size(52, 20);
            this.experimentalButton.TabIndex = 7;
            this.experimentalButton.Text = "secret experimental";
            this.experimentalButton.UseVisualStyleBackColor = false;
            this.experimentalButton.Click += new System.EventHandler(this.experimentalButton_Click);
            // 
            // allInButton
            // 
            this.allInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.allInButton.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allInButton.Location = new System.Drawing.Point(1087, 655);
            this.allInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allInButton.Name = "allInButton";
            this.allInButton.Size = new System.Drawing.Size(124, 124);
            this.allInButton.TabIndex = 6;
            this.allInButton.Text = "ALL IN";
            this.allInButton.UseVisualStyleBackColor = false;
            this.allInButton.Click += new System.EventHandler(this.allInButton_Click);
            // 
            // BlackJackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1277, 814);
            this.Controls.Add(this.dealerHandLabel);
            this.Controls.Add(this.playerHandLabel);
            this.Controls.Add(this.shuffleLabel);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.experimentalButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.clearBetButton);
            this.Controls.Add(this.hundButton);
            this.Controls.Add(this.twfivButton);
            this.Controls.Add(this.tenButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.allInButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.cardsRemainingLabel);
            this.Controls.Add(this.crLabel);
            this.Controls.Add(this.playerBalanceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentBetLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.playerMoneyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dealerExpandedHand);
            this.Controls.Add(this.playerExpandedHand);
            this.Controls.Add(this.reasonLabel);
            this.Controls.Add(this.winloseLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BlackJackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "blackjackForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BlackJackForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
               
        #endregion
        private System.Windows.Forms.Label playerMoneyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button tenButton;
        private System.Windows.Forms.Button twfivButton;
        private System.Windows.Forms.Button hundButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerBalanceLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label currentBetLabel;
        private System.Windows.Forms.Button clearBetButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Label playerExpandedHand;
        private System.Windows.Forms.Label dealerExpandedHand;
        private System.Windows.Forms.Label crLabel;
        private System.Windows.Forms.Label cardsRemainingLabel;
        private System.Windows.Forms.Label playerHandLabel;
        private System.Windows.Forms.Label dealerHandLabel;
        private System.Windows.Forms.Label winloseLabel;
        private System.Windows.Forms.Label reasonLabel;
        private System.Windows.Forms.Label shuffleLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shuffleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeckMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshScreenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDeckMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerHandMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCard1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCard2MenuItem;
        private System.Windows.Forms.ToolStripMenuItem pNewCardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dealerHandMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dCard1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem dCard2MenuItem;
        private System.Windows.Forms.ToolStripMenuItem dNewCardMenuItem;
        private System.Windows.Forms.Button experimentalButton;
        private System.Windows.Forms.Button allInButton;
    }
}