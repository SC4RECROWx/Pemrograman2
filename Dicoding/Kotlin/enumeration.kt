package com.dicoding.kotlin

fun main(){
    val colorRed = Color.RED
    val colorBlue = Color.BLUE
    val colorGreen = Color.GREEN

    val warnaMerah = Warna.MERAH
    val warnaBiru = Warna.BIRU
    val warnaHijau = Warna.HIJAU
}

enum class Color(val value: String){
    RED("hello"),
    GREEN("hewwo"),
    BLUE("heio")
}

enum class Warna{
    MERAH,HIJAU,BIRU
}
