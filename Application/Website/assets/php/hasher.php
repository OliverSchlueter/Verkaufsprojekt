<?php

function hashPassword($id, $password) {

    $version = "001:";

    $hash = hash("sha512", $id."n");
    $hash = hash("sha512", $hash);
    $hash = hash("sha512", "97".$password."!!");
    $hash = hash("sha512", $hash.$id);

    for ($i=0; $i < 5713; $i++) { 
        $hash = hash("md2", $hash);
        $hash = hash("sha512", $hash);
        $hash = hash("ripemd320", $hash."cool password lol");
    }

    for ($i=0; $i < 84; $i++) { 
        $hash = hash("sha512", $hash);
        $hash = hash("md2", $hash);
        $hash = hash("sha512", $hash);
        $hash = hash("ripemd320", $hash);
        $hash = hash("haval192,5", $hash);
        $hash = hash("snefru", $hash);
        $hash = hash("sha3-256", $hash);
        $hash = hash("crc32b", $hash);
        $hash = hash("joaat", $hash);
        $hash = hash("haval224,4", $hash."laksfnaskfnalsfnhaslfjlasfbajsfbjasf");
        $hash = hash("gost", $hash);
        $hash = hash("whirlpool", $hash);
        $hash = hash("fnv132", $hash);
        $hash = hash("haval192,3", $hash);
        $hash = hash("haval256,5", $hash);

        for ($i=0; $i < 145; $i++) { 
            $hash = hash("sha512", $hash);
            $hash = hash("crc32b", $hash);
            $hash = hash("md2", $hash);
            $hash = hash("sha512", $hash);
            $hash = hash("ripemd320", $hash);
            $hash = hash("haval192,5", $hash.$hash."ouzriqtuariqwrziuqr628418779");
            $hash = hash("whirlpool", $hash);
            $hash = hash("adler32", $hash);
            $hash = hash("haval224,5", $hash);
            $hash = hash("snefru", $hash);
            if($i % 5 == 0){
                $hash = hash("whirlpool", $hash);
                $hash = hash("fnv132", $hash);
                $hash = hash("haval192,3", $hash);
            }
            $hash = hash("haval256,5", $hash);
            $hash = hash("sha3-256", $hash.$hash.$hash.$hash.$hash.$hash.$hash.$hash.$hash);
            $hash = hash("crc32b", $hash);
            $hash = hash("adler32", $hash);
            $hash = hash("sha512", $hash);
            $hash = hash("sha512", $hash);
            $hash = hash("sha512", $hash);
            $hash = hash("whirlpool", $hash);
            $hash = hash("adler32", $hash);
            $hash = hash("whirlpool", $hash);
            $hash = hash("joaat", $hash);
            $hash = hash("haval224,4", $hash.$hash.$hash);
            $hash = hash("gost", $hash);
            $hash = hash("whirlpool", $hash);
            $hash = hash("sha512", $hash);
            $hash = hash("ripemd320", $hash.$hash.$hash.$hash.$hash.$hash);
            $hash = hash("sha512", $hash);
            $hash = hash("whirlpool", $hash);
            $hash = hash("sha256", $hash);
            $hash = hash("crc32b", $hash);
            $hash = hash("whirlpool", $hash.$hash.$hash.$hash.$hash.$hash.$hash.$hash.$hash.$hash);
            $hash = hash("adler32", $hash);
            $hash = hash("sha512", $hash);
            $hash = hash("haval224,5", $hash);
            $hash = hash("crc32b", $hash);
            $hash = hash("sha512", $hash);
            $hash = hash("whirlpool", $hash);
        }

        $hash = hash("whirlpool", $hash);
        $hash = hash("sha512", $hash);
        $hash = hash("ripemd320", $hash);
        $hash = hash("whirlpool", $hash);
        $hash = hash("sha256", $hash);
        $hash = hash("whirlpool", $hash."ouabgoawgiaugbsgas7g6a7sgasigas7g5asg5");
        $hash = hash("adler32", $hash);
        $hash = hash("whirlpool", $hash);
        $hash = hash("adler32", $hash);
        $hash = hash("whirlpool", $hash);
        $hash = hash("adler32", $hash);
        $hash = hash("haval224,5", $hash);
        $hash = hash("whirlpool", $hash);
    }

    for ($i=0; $i < 541; $i++) { 
        $hash = hash("whirlpool", $hash);
        $hash = hash("sha512", $hash);
        $hash = hash("gost", $hash);
        $hash = hash("whirlpool", $hash.$hash);
        $hash = hash("sha384", $hash);
    }

    $hash = hash("adler32", $hash);

    return $version.$hash;
}

?>