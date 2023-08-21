//CONTOH FUNGSI
    val rangeInt = 1.rangeTo(10)
    val downInt = 10.downTo(1)

// CONTOH 1
fun main(){
    val rangeInt = 1..10 step 2
    rangeInt.forEach{
        print("$it")
    }
    println(rangeInt.step)
}

// CONTOH 2
    fun main() {
        val tenToOne = 10.downTo(1)
        if (7 in tenToOne) {
            println("Value 7 available")
        }
    }
    /*
       output: Value 7 available
    */

// CONTOH 3
fun main(){
    val tenToOne = 10.downTo(1)
    tenToOne.forEach{
        print("$it")
    }
}

// CONTOH 4
    fun main() {
        val tenToOne = 10.downTo(1)
        if (11 !in tenToOne) {
            println("No value 11 in Range ")
        }
    }
    /*
       output: No value 11 in Range
    */

/*
jadi perulangan for loop pada kotlin pertama kita harus memasukkan semua data kedalam variabel lalu kita
loop meggunakan forEach
*/
