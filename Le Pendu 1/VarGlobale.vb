Imports System
Imports System.IO
Module VarGlobale
    Public ChArray As Char()
    Public go As Integer
    Public bck As Integer = 0
    Public Word As String
    Public kl As Integer
    Public Count() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Public Words() As String
    Public Cat1() As String = {"PORTE", "PLAFOND", "CHAISE", "BUREAU", "PLACARD", "FENETRE", "CHEMINEE", "GRENIER", "GARAGE", "ETAGE", "PLANCHER", "FONDATION", "ESCALIER", "SALLE DE BAIN", "CHAMBRE", "LE  SALON", "CUISINE", "COULOIR", "BALCON", "JARDIN"}
    Public Cat2() As String = {"PANTALON", "CHEMISE", "MANTEAU", "CHAUSSETTES", "ROBE", "JUPE", "COLLANTS", "T-SHIRT", "BLOUSE", "CRAVATE", "CHAPEAU", "SHORT", "PANTOUFLES", "ESCARPINS", "JEANS", "ECHARPE", "FOULARD", "GANTS", "BOTTES", "VESTE"}
    Public Cat3() As String = {"REGLE", "STYLO A BILLE", "GOMME", "CRAYONS", "STYLOS", "CISEAUX", "AIGUISOIR", "AGRAFEUSE", "CAHIER", "KIT GEOMETRIQUE", "COMPAS", "RAPPORTEUR", "EQUERRE", "STYLO-PLUME", "TROUSSE", "ENCRE", "CARTABLE", "REZERVATIONS STYLO", "COULEUR D'EAU", "PINCEAUX"}
    Public Cat4() As String = {"GRAND-MERE", "GRAND-PERE", "PARENTS", "MERE", "PERE", "GRAND-PARENTS", "FILS", "FILLE", "ONCLE", "TANTE", "COUSIN", "PETIT-FILLS", "PETITE FILLE", "ENFANTS", "PARRAIN", "MARRAINE", "DEMI-FRERE", "DEMI-SOEUR", "BEAU-PERE", "BELLE-MERE"}
    Public Cat5() As String = {"LE CHIEN", "LE CHAT", "LE HAMSTER", "LE LAPIN", "LE PINGOUIN", "L'OURS POLAIRE", "LE MORSE", "LE PHOQUE", "LE COCHON", "LE POISSON", "L'ELEPHANT", "LE GIRAFE", "LE VACHE", "LE CROCODILE", "LE CHEVAL", "LE POULE", "LE ZEBRE", "LE TIGRE", "LE MOUTON", "LE RHINOCEROS"}
    Public Cat6() As String = {"CAPABLE", "DILIGENT", "BRAVE", "COMMUNICATIF", "AIMABLE", "ENTHOUSIASTE", "SYMPATHIQUE", "MODESTE", "PASSIONNANT", "RESPONSABLE", "GROSSIER", "AVARE", "NEGLIGEANT", "IMPRUDENT", "HYPOCRITE", "CRUEL", "PROFITEUR", "IRRESPONSABLE", "RACISTE", "STUPIDE"}
    Public Cat7() As String = {"TIRE-BOUCHON", "PLACARD", "FOUR", "VERRE", "POELE", "EVIER", "FOURCHETTE", "TASSE", "TIROIS", "REFRIGERATEUR", "SERVIETTES", "LAVE-VAISSELLE", "CUILLER", "FOURNEAU A GAZ", "ASSIETTE", "CASSERROLE", "LOUCHE", "MICRO-ONDE", "TABLE", "BUREAU"}
    Public Cat8() As String = {"ABOU DABI", "AMSTERDAM", "ANKARA", "ATHENES", "BRUXELLES", "BUCAREST", "JERUSALEM", "LISBONNE", "LONDRES", "NAIROBI", "PHILIPPINES", "MEXIQUE", "AFRIQUE DU SUD", "ITALIE", "BOSNIE-HERZEGOVINE", "CROATIE", "UKRAINE", "HONGRIE", "ARGENTINE", "THAILANDE"}
    Public Cat9() As String = {"BIODIVERSITE", "TRIER", "GASPILLER", "ESPECE", "POLLUTION", "RECYCLER", "AGIR", "DECHET", "ECHAUFFER", "PROTEGER", "POLLUER", "CATACLISMES", "ANIMAUX", "COUCHE D'OZONE", "VOITURES", "MALADIES", "ECOLOGIE", "GAZ", "SECHERESSE", "EXPLOITATION"}
    Public Cat10() As String = {"EXECUTION", "SE DECONNECTER", "SOURIS", "ORDINATEUR PORTABLE", "CLAVIER", "INTERNET", "IMPRIMANTE", "TELEPHONE PORTABLE", "CHARGEUR DE BATTERIE", "INTERNET SANS FIL", "SYSTEME", "PROCESSEUR", "JOYSTICK", "CONSOLE DE JEU PORTABLE", "CAMERA VIDEO", "WEB CAMERA", "CASQUE AUDIO", "MICROPHONE", "ROUTEUR", "REFROIDISSEUR"}
    Public hints() As String
    Public hnts1() As String = {"Donnant passage à l'intérieur comme à l'extérieur d'un lieu fermé ou enclos.", "Surface plane formant la partie supérieure d’un lieu couvert", "Siège à dossier, sans bras.", "Meuble muni d’un plateau horizontal et souvent de tiroirs, conçu pour écrire, travailler.", "Espace de rangement aménagé dans un mur et fermé par une porte, où l’on peut suspendre des vêtements.", "Ouverture dans un mur pour permettre le passage de l’air et de la lumière.", "Construction se composant d’un âtre et d’un conduit communiquant avec l’extérieur pour laisser s’échapper la fumée", "Étage supérieur d’une maison.", "Endroit servant d’abri aux véhicules.", "Chacun des niveaux d’un immeuble à l’exclusion du rez-de-chaussée et des sous-sols.", "Sol d’une pièce, séparation entre deux étages.", "Base, fondement.", "Suite de marches pour monter ou descendre.", "Pièce où vous vous lavez.", "Pièce où l’on dort.", "Pièce d’une maison.", "Endroit où l’on prépare les repas.", "Passage étroit qui conduit d’une pièce à une autre.", "Plateforme disposée en saillie sur la façade d’un immeuble.", "Terrain où l’on cultive des légumes, des fleurs, etc."}
    Public hnts2() As String = {"Culotte à jambes longues.", "Vêtement (surtout masculin) qui couvre le torse", "Vêtement porté par-dessus les autres vêtements pour se protéger des intempéries.", "Vêtement en tricot qui couvre le pied et la cheville.", "Vêtement féminin d’une seule pièce, composé d’un corsage et d’une jupe.", "Partie de l’habillement féminin qui descend de la ceinture à la jambe.", "Sous-vêtement d’une seule pièce constitué d’une culotte et de bas.", "un top casual manches courtes", "Vêtement de travail", "Pièce d’étoffe qui se noue autour du col de la chemise.", "un revêtement en forme pour la tête porté pour la chaleur", "Culotte courte de sport", "Chaussure d’intérieur.", "Chaussure découverte et légère.", "Pantalon de toile", "Bande de tricot, de tissu portée autour du cou.", "Carré de tissu léger que l’on porte autour du cou ou sur la tête.", "Partie de l’habillement qui couvre la main et les doigts séparément.", "Chaussure qui protège le pied et la jambe.", "Vêtement court comportant des manches, ouvert à l’avant et qui se porte sur une chemise, un tricot."}
    Public hnts3() As String = {"Instrument servant à tracer une ligne droite, à mesurer une longueur.", "Vous écrivez avec lui et il n'a pas utilisez de l'encre.", "Petit bloc de caoutchouc pour effacer les traits de crayon.", "Baguette comprenant une mine noire ou de couleur et servant à écrire, à dessiner.", "Porte-plume à réservoir d'encre.", "Outil de métal destiné à travailler le bois, le métal, etc.", "Outil qui sert à aiguiser.", "Petit appareil servant à agrafer, entre autres, des feuilles de papier.", "Assemblage de feuilles de papier liées ensemble.", "Contient différents types d'outils géométriques.", "Un instrument de géométrie qui sert à tracer des cercles ou des arcs de cercle.", "Un outil utilisé en géométrie pour mesurer des angles.", "Il est utilisée soit pour vérifier des angles dièdres droits, soit pour tracer des angles plans droits.", "Il est utilisé pour écrire à l'encre et il est d'un oiseau.", "Pochette, étui où est rangé un ensemble d’objets.", "Liquide utilisé pour écrire, imprimer, etc.", "Sac d’écolier à plusieurs compartiments.", "Il est utilisé pour remplir le stylo.", "Il est utilisé en même temps que le pinceau.", "Ensemble de poils fixés à un manche dont on se sert pour appliquer de la peinture, de la colle, etc."}
    Public hnts4() As String = {"Mère du père ou de la mère", "Père du père ou de la mère.", "Le père ou la mère.", "Femme qui a donné naissance à un ou à plusieurs enfants.", "Celui qui a un ou plusieurs enfants.", "Le grand-mère et grand père.", "Personne de sexe masculin considérée par rapport à sa mère, à son père (par opposition à fille ).", "Personne du sexe féminin considérée par rapport à sa mère, à son père (par opposition à fils ).", "Frère du père ou de la mère.", "Sœur du père ou de la mère", "Se dit d’enfants qui sont nés ou descendent de frères ou de sœurs.", "Fils, fille d’un fils ou d’une fille, par rapport au grand-père, à la grand-mère.", "Fils, fille d’un fils ou d’une fille, par rapport au grand-père, à la grand-mère.", "Être humain dans l’âge de l’enfance.", "Celui qui tient un enfant sur les fonts baptismaux.", "Personne qui tient un enfant (son filleul, sa filleule) lors du baptême et qui, dans une certaine mesure, en demeure responsable.", "Frère par le père ou la mère seulement.", "Sœur par le père ou la mère seulement.", "Père du conjoint.", "Seconde femme du père pour les enfants issus d’une précédente union."}
    Public hnts5() As String = {"Le mei-lleur ami de l'homme", "L'ennemi de chien", "Petit rongeur", "Manger des carottes", "Vit au pôle sud et ne volent pas", "Mammifère qui vit dans les zones polaire", "A deux grands tooths et vit sous l'eau", "Mammifère vivant près des côtes arctiques.", "Animal qui aime la boue", "Animal trouvé dans l'eau", "Plus grand pachyderme sur terre", "Ruminant à cou très long et au pelage roux tacheté de brun", "Donne du lait et a des cornes", "Grand reptile amphibie à fortes mâchoires.", "Animal domestique de grande taille, mammifère qui appartient à l’ordre des équidés.", "Femelle du coq élevée pour ses œufs et sa chair.", "Mammifère ongulé voisin du cheval et dont la robe claire est marquée de bandes", "Grand mammifère carnassier dont le pelage roux est rayé de bandes noires.", "Mammifère ruminant élevé pour sa laine, sa chair et son lait, qui sert à la fabrication de fromages.", "Mammifère pachyderme très massif qui porte une ou deux cornes sur le nez."}
    Public hnts6() As String = {"Synonyme de Compétent.", "Synonyme de Prompt.", "Synonyme de Courageux.", "Quelqu'un qui parle très bien avec les gens.", "Qui est de nature à plaire, affable.", "Qui ressent de l’enthousiasme, qui est rempli d’admiration.", "Aimable, qui attire la sympathie.", "Qui est exempt de vanité.", "Qui cause un vif intérêt.", "Qui doit s’occuper de quelqu’un et répondre de ses actes.", "Synonyme de impoli.", "Qui aime l’argent.", "Synonyme d'ignorer.", "Qui manque de prudence.", "Qui a de l’hypocrisie, qui est sournois.", "Qui se plaît à faire souffrir.", "Personne qui abuse de la générosité d’autrui.", "Irréfléchi, qui agit sans penser aux conséquences.", "Qui fait preuve de racisme, qui est hostile à certains groupes raciaux.", "Niais, abruti."}
    Public hnts7() As String = {"Instrument servant à déboucher les bouteilles.", "Espace de rangement aménagé dans un mur et fermé par une porte.", "Ouvrage de maçonnerie servant à cuire (le pain, la pâtisserie).", "Récipient pour boire.", "Est un ustensile de cuisine utilisé pour la cuisson d'aliments solides tels que la viande, les légumes, les œufs…", "Laver la vaisselle dans la cuisine.", "Ustensile de table.", "Récipient, généralement à anse, qui sert à boire.", "Partie d’un meuble qui coulisse.", "S’abrège familièrement en frigo.", "Linge dont on se sert pour s’essuyer.", "Machine à laver la vaisselle.", "Ustensile de table.", "Appareil utilisé pour la cuisson des aliments.", "Pièce de vaisselle à fond plat.", "Récipient muni d’un manche et parfois d’un couvercle, réservé à la cuisson des aliments.", "Qui n’est pas ou ne semble pas honnête.", "Onde de très petite longueur.", "Meuble composé d’une surface plane posée sur des pieds et qui sert à divers usages.", "Instrument tranchant."}
    Public hnts8() As String = {"Émirats arabes unis", "Pays-Bas", "Turquie", "Grèce", "Belgique", "Roumanie", "Israël", "Portugal", "Royaume-Uni", "Kenya", "Manille", "Mexico", "Bloemfontein", "Rome", "Sarajevo", "Zagreb", "Kiev", "Budapest", "Buenos Aires", "Bangkok"}
    Public hnts9() As String = {"Diversité des espèces vivantes d’un milieu.", "Sélectionner, choisir, particulièrement ce qui est meilleur.", "Consommer à l’excès, ne pas utiliser au mieux.", "Groupe d’êtres, d’éléments du même genre.", "Dégradation d’un milieu naturel (eau, sol, air) par des substances, des déchets toxiques.", "Convertir (déchets) en matériaux réutilisables.", "Exercer une action.", "Débris, résidu.", "Donner de la chaleur à.", "Préserver, aider.", "Salir, dégrader l’environnement.", "Désastre naturel d’une grande ampleur.", "Opposition à végétaux et minéraux", "Protège la terre des ultra-violettes.", "Véhicule qui sert au transport des personnes, des choses.", "Altération de la santé, mauvais état de l’organisme.", "Étude des êtres vivants et de leurs relations avec le milieu où ils vivent.", "Corps à l’état gazeux.", "Aridité.", "Action d’exploiter, de faire valoir quelque chose en vue d’un profit."}
    Public hnts10() As String = {"Lorsque vous démarrez un programme d'ordinateur.", "Lorsque vous quittez à partir d'un compte.", "Aussi un animal.", "Aussi connu sous le nom ''Laptop''.", "Ensemble de touches d'ordinateur.", "Réseau informatique mondial constitué d’un ensemble de réseaux nationaux", "Unité périphérique d’un ordinateur apte à produire une représentation permanente de données sous la forme de suites de caractères.", "Vous pouvez parler à partout.", "Dispositif utilisé pour recharger un appareil mobile.", "Aussi connu sous le nom ''WIFI''.", "Vous en avez besoin d'utiliser un ordinateur.", "Unité centrale d’un ordinateur.", "Anglicisme pour manette de jeu, manche à balai.", "Vous pouvez jouer à des jeux partout avec elle.", "Appareil de prises de vues cinématographiques.", "Petite caméra numérique, branchée sur l’ordinateur.", "Utilisé pour écouter de la musique sans que les autres d'entendre.", "Instrument servant à transformer et à amplifier le son.", "Équipement d’interconnexion, installé à un nœud de réseau.", "Utilisée pour refroidir un ordinateur portable."}

    Public categorie As Integer
    Public Coins As Integer = 10
    Public a As Integer = 1
    Public b As Integer

    Public Sub ResetColors()
        FormWord.lblSubject.ForeColor = Color.Black
        FormWord.lblCount.ForeColor = Color.Black
        FormWord.lblCoins.ForeColor = Color.Black
        FormWord.lblWrong.ForeColor = Color.Black
        FormWord.lblWord.ForeColor = Color.Yellow
    End Sub

    Public Sub Again()
        Count = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Reset()
        FormWord.lblCount.Text = "Bons Mots: 0 /20"
    End Sub

    Public Sub labelWord()
        Dim i As Integer
        ChArray = Word.ToCharArray
        FormWord.lblWord.Text = Word(0)
        For i = 1 To Word.Length - 1
            If Word(i) = " " Then
                FormWord.lblWord.Text += "  "
                ChArray(i) = "a"
            ElseIf Word(i) = "'" Then
                FormWord.lblWord.Text += " '"
                ChArray(i) = "c"
            ElseIf Word(i) = "-" Then
                FormWord.lblWord.Text += " -"
                ChArray(i) = "d"
            ElseIf Word(i) = Word(0) Then
                FormWord.lblWord.Text += " " + Word(0)
                ChArray(i) = Word(0)
            Else
                FormWord.lblWord.Text += " _"
                ChArray(i) = "b"
            End If
        Next
        FormWord.lblCoins.Text = "Crédit: " + CStr(Coins)
    End Sub

    Public Sub btnVisible()
        FormWord.btnA.Visible = True
        FormWord.btnB.Visible = True
        FormWord.btnC.Visible = True
        FormWord.btnD.Visible = True
        FormWord.btnE.Visible = True
        FormWord.btnF.Visible = True
        FormWord.btnG.Visible = True
        FormWord.btnH.Visible = True
        FormWord.btnI.Visible = True
        FormWord.btnJ.Visible = True
        FormWord.btnK.Visible = True
        FormWord.btnL.Visible = True
        FormWord.btnM.Visible = True
        FormWord.btnN.Visible = True
        FormWord.btnO.Visible = True
        FormWord.btnP.Visible = True
        FormWord.btnQ.Visible = True
        FormWord.btnR.Visible = True
        FormWord.btnS.Visible = True
        FormWord.btnT.Visible = True
        FormWord.btnU.Visible = True
        FormWord.btnV.Visible = True
        FormWord.btnW.Visible = True
        FormWord.btnX.Visible = True
        FormWord.btnY.Visible = True
        FormWord.btnZ.Visible = True
    End Sub

    Public Sub btnEnable(boo As Boolean)
        FormWord.btnA.Enabled = boo
        FormWord.btnB.Enabled = boo
        FormWord.btnC.Enabled = boo
        FormWord.btnD.Enabled = boo
        FormWord.btnE.Enabled = boo
        FormWord.btnF.Enabled = boo
        FormWord.btnG.Enabled = boo
        FormWord.btnH.Enabled = boo
        FormWord.btnI.Enabled = boo
        FormWord.btnJ.Enabled = boo
        FormWord.btnK.Enabled = boo
        FormWord.btnL.Enabled = boo
        FormWord.btnM.Enabled = boo
        FormWord.btnN.Enabled = boo
        FormWord.btnO.Enabled = boo
        FormWord.btnP.Enabled = boo
        FormWord.btnQ.Enabled = boo
        FormWord.btnR.Enabled = boo
        FormWord.btnS.Enabled = boo
        FormWord.btnT.Enabled = boo
        FormWord.btnU.Enabled = boo
        FormWord.btnV.Enabled = boo
        FormWord.btnW.Enabled = boo
        FormWord.btnX.Enabled = boo
        FormWord.btnY.Enabled = boo
        FormWord.btnZ.Enabled = boo
    End Sub

    Public Sub Reset()
        NextWord()
        labelWord()
        FormWord.lblWrong.Text = ""
        FormWord.PicHangman.Image = My.Resources.sfoara_fara_cap
        FormWord.btnHint.Enabled = True
        go = 0
        FormWord.btnHint.Enabled = True
        btnVisible()
        FormWord.Button2.Visible = False
        btnEnable(True)
    End Sub

    Public Sub NextWord()
        Dim Random As New System.Random()
        Dim c As Integer = 0
        Randomize()
        While c <> 1
            b = Random.Next(0, 20)
            If Count(b) <> 1 Then
                c = 1
                kl = b
                Count(b) = 1
            End If
        End While

        Word = Words(b)
        ChArray = Word
        FormWord.btnHnt.Enabled = True
    End Sub
End Module