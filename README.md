# Gestion-Usine_Developpement-Client-serveur
<h1 align="left" style="color:#7952B3">Project Gestion de Production : </h1>
<p style="font-family:sans-serif;font-size:17px">
   Un Usine vous demande de développer une application de suivi de la production. L’analyse a permis de
construire le modèle de base de données suivant :

<div style="background-color: #343A40;padding:20px 10px;border:none;border-radius:15px;width:75%">
    • Employe ( Mat : int, Nom : varchar(20), Prenom : varchar(20), DN : dateTime, Adresse : varchar(120), Tel : varchar(60))
    <br>
    • Article ( codea : int, Designation : varchar(50), Prix : real, Stock : int )
    <br>
    • Production (Num : int, DP : dateTime, Mat : int, codea : int, qtitep : int )
    <br>
    • wproduction (Num : int, DP : dateTime, Mat : int, NP : varchar(40), codea : int, Designation : varchar(50), qp : int )
</div> 
<div style="font-family:sans-serif;font-size:17px;margin:12px 0 0 10px">
    <p style="color:#343A40">Interface de Project : </p>
    <img src="https://d.top4top.io/p_22227nvd81.png" style="width:75%"/>
</div>
<hr style="border: 3px solid #FFC107;outline:none;border-radius: 5px">
<div>
    Développer les formulaires de mise à jour des employés et des articles.
    <br>
• Les données de la production sont saisies dans la table wproduction qui est considérée comme unetable de travail. Avant de commencer, l’utilisateur entre la date de la production (qui doit êtreinitialisée par la date système) et click sur le bouton générer pour exécuter les taches suivantes :
<br>
- Suppression de tout le contenu de la table wproduction. Afficher un messaged’avertissement lorsque la table n’est pas vide avec une possibilité d’abandon del’opération.
<br>
- Remplissage de la table wproduction par le produit cartésien des tables employé et article.
<br>
La date de production est initialisée par celle que l’utilisateur a saisie sur le formulaire.
<br>
Pour faciliter cette opération, créer une procédure stockée. Utiliser une grille pour la saisie,verrouiller toutes les colonnes sauf celle qui correspond à la quantité produite.
<br>
• Après la saisie des données de la production, l’utilisateur peut procéder à leur validation (option «validation de la saisie » du menu « Production »), ce qui aura pour conséquence :
<br>
- Le transfert de tous les enregistrements de la table wproduction vers la table production.Utiliser une procédure stockée pour cette opération.
<br>
- Suppression de tout le contenu de la table wproduction.
<br>
• L’option « consultation » du menu « Production » permet d’afficher le contenu de la table «production ».
<br>
• Développez avec Crystal Report les états suivants :
<br>
- liste des employés
<br>
- Liste des articles.
<br>
- Production par période : l’utilisateur entre une période d1, d2 et l’application affiche laliste des données de production réalisée entre ces deux dates. Utiliser une procédurestockée pour cet état.
<br>
- Histogramme de production : affiche un histogramme par article et production cumulée.Utiliser une procédure stockée.
<br>
• Développer une fenêtre « A propos » qui affiche le nom, numéro de version de l’application, votrenom et prénom.
</div>
</p>

