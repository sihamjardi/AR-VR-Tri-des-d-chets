# ♻️ **Tri des Déchets – Jeu Unity**

---
## 🧩 **Description**
Ce projet Unity est un *jeu éducatif interactif* sur **le tri des déchets**.  
Le joueur doit **faire glisser** chaque déchet (plastique, métal, verre, organique, etc.) vers **la bonne poubelle**.  
Lorsqu’un déchet est déposé dans la poubelle correspondante, il **disparaît à l’intérieur**.

> ### 🗑️ **Consigne au démarrage :**  
> *Drag each object with the mouse and drop it into the corresponding bin:*  
> **Plastic → Blue**, **Metal → Yellow**, **Glass → Green**, **Food/Organic → Red**
Le jeu ne comporte **aucun score** : il a pour objectif de **sensibiliser au tri sélectif** de manière simple, visuelle et intuitive.
---

## 💡 **Fonctionnalités principales**
-  **Interaction Drag & Drop** fluide  
-  **Détection automatique** du bon bac  
-  **Poubelles semi-transparentes** pour plus de réalisme  
-  **Environnement 3D** (jardin, objets, plan)  
-  **Interface simple** avec consigne d’introduction  

---

## 🛠️ **Technologies utilisées**

| Technologie | Rôle |
|--------------|------|
|  **Unity** | Moteur de jeu |
|  **C#** | Logique du tri (scripts) |
|  **TextMeshPro** | Interface utilisateur et texte |

---

##  **Étapes de réalisation**

### 🔹 **Étape 1 – Création du projet Unity**
- Ouvrir **Unity Hub** → *New Project (3D)*  
- Nommer le projet : `TriDesDechets`  
- Configurer la scène principale : **Environnement**

---

### 🔹 **Étape 2 – Importation des objets 3D**
- Ajouter les modèles : **poubelles** (plastique, métal, verre, organique) et **déchets** (bouteille, canette, fruit, etc.)  
- Organiser les objets dans la scène 3D pour créer un espace de jeu harmonieux  
<img width="489" height="233" alt="Capture d&#39;écran 2025-10-30 223749" src="https://github.com/user-attachments/assets/e20ab05b-79ec-4b60-bf21-1816a5a85d3b" />

---

### 🔹 **Étape 3 – Configuration des collisions et du Drag & Drop**

L’interaction principale du jeu repose sur le **glisser-déposer** des déchets dans les bonnes poubelles.  
Deux scripts principaux ont été développés : **`Draggable.cs`** et **`Bin.cs`**.

####  **1. Script `Draggable.cs`**
Ce script permet de **prendre un déchet avec la souris**, de le **déplacer librement** dans la scène, puis de le **relâcher** dans une poubelle.
<img width="298" height="267" alt="image" src="https://github.com/user-attachments/assets/b6d913d9-75b2-4d06-94d5-aa873bee3b8e" />
<img width="452" height="364" alt="image" src="https://github.com/user-attachments/assets/198c47b2-687c-4f95-9c3a-0348c74339f6" />
<img width="406" height="330" alt="image" src="https://github.com/user-attachments/assets/2ec947fa-1e1a-44ba-9d90-04110a578e4b" />


**Fonctionnement :**
- `OnMouseDown()` → le joueur commence à glisser l’objet  
- `Update()` → la position de l’objet suit le curseur via un **raycast**  
- `OnMouseUp()` → vérifie si le déchet est déposé dans une zone contenant une poubelle (`Bin`)  
  - ✅ Si la poubelle correspond au bon type (`binType == tag`), le déchet est accepté  
  - ❌ Sinon, le déchet revient à sa position d’origine  

#### 🗑️ **2. Script `Bin.cs`**
Ce script gère la **réception du déchet** dans la poubelle.  
Lorsqu’un objet correct est déposé, il est **placé à l’intérieur** et **désactivé** pour simuler sa disparition.
<img width="518" height="340" alt="image" src="https://github.com/user-attachments/assets/edccef71-94cd-4a82-8509-9ca6d1e32f56" />

---

### 🔹 **Étape 4 – Interface et consignes**
- Ajouter un **Canvas** avec **TextMeshPro**  
- Afficher un message d’introduction :  
  > “Drag each object with the mouse and drop it into the corresponding bin:  
  > plastic in Blue, metal in yellow, glass in green, food or organic in red”
<img width="936" height="434" alt="Capture d&#39;écran 2025-10-30 225451" src="https://github.com/user-attachments/assets/983113d5-4481-4d44-92b6-610a78c60905" />

---

### 🔹 **Étape 5 – Tests et ajustements**
- Vérifier le **bon fonctionnement** des interactions  
- Ajuster les **textures, lumières et positions** des objets  
- S’assurer que chaque déchet **disparaît** dans la bonne poubelle  
<img width="780" height="403" alt="Capture d&#39;écran 2025-10-30 225650" src="https://github.com/user-attachments/assets/4dbe548f-5c3c-46ff-8ef9-abe3eed78ff6" />

---


## 🎥 **Vidéo Démonstration** 
 
https://youtu.be/KvDBb9wlAds

---

## **Auteur** 
Projet réalisé par *Siham Jardi*


