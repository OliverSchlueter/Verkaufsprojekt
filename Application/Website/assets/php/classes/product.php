<?php

class Product{
    var $id;
    var $name;
    var $price;
    var $description;
    var $releaseDate;

    public function __construct($id, $name, $price, $description, $releaseDate){
        $this->id = $id;
        $this->name = $name;
        $this->price = $price;
        $this->description = $description;
        $this->releaseDate = $releaseDate;
    }
}


function getAllProductIDs($db){
    $currentIDs = [];

    foreach($db->query("SELECT produktID FROM produkt") as $row){
        $currentIDs[count($currentIDs)] = $row['produktID'];
    }
    
    return $currentIDs;
}

function getNewProductID($db){
    $currentIDs = getAllProductIDs($db);

    $validCharsS = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ01234567890123456789";
    $validChars = str_split($validCharsS);

    while (true) {
        $id = "";
        for ($i=0; $i <5; $i++) { 
            $id .= $validChars[random_int(0,count($validChars))];
        }

        if(!in_array($id, $currentIDs)){
            return $id;
        }
    }
}

?>