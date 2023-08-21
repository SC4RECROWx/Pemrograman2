// CONTOH 1
fun main(){
    val num = 1.rangeTo(5)
    for(i in num){
        println(i)
    }
}

// CONTOH 2
fun main(){
    val num = 1.rangeTo(10) step 3
    for(i in num){
        println(i)
    }
}

// CONTOH 3
fun main() {
    val ranges = 1.rangeTo(10) step 3
    for ((index, value) in ranges.withIndex()) {
        println("value $value with index $index")
    }
}
/*
   output :
       value 1 with index 0
       value 4 with index 1
       value 7 with index 2
       value 10 with index 3
*/
