package com.dicoding.kotlin

fun main(){
    val value = 7
    val stringOfValue = when(value){
        6 -> "Value is 6"
        7 -> "Value is 7"
        8 -> "Value is 8"
        else -> "Value is not reached"
    }

    println(stringOfValue)
}

// CONTOH2
val value = 7
    val stringOfValue = when (value) {
        6 -> {
            println("Six")
            "value is 6"
        }
        7 -> {
            println("Seven")
            "value is 7"
        }
        8 -> {
            println("Eight")
            "value is 8"
        }
        else -> {
            println("undefined")
            "value cannot be reached"
        }
    }
 
    println(stringOfValue)
}
 
/*
   output : 
            Seven
            value is 7
 
*/

// CONTOH 3
    fun main() {
        val anyType : Any = 100L
        when(anyType){
            is Long -> println("the value has a Long type")
            is String -> println("the value has a String type")
            else -> println("undefined")
        }
    }
     
    /*
       output : the value has a Long type
    */

// CONTOH 4
    fun main() {
        val value =  27
        val ranges = 10..50
     
        when(value){
            in ranges -> println("value is in the range")
            !in ranges -> println("value is outside the range")
            else -> println("value undefined")
        }
    }
     
    /*
       output : value is in the range
    */

// CONTOH 5
    fun main() {
        val registerNumber = when(val regis = getRegisterNumber()){
            in 1..50 -> 50 * regis
            in 51..100 -> 100 * regis
            else -> regis
        }
    }
     
    fun getRegisterNumber() = Random.nextInt(100)
