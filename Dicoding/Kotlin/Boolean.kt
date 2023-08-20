fun main(){
    // Boolean
    var officeOpen: Int = 7
    var officeClosed: Int = 16
    var now: Int = 20

    // And
    var isOpen: Boolean = if(now >= officeOpen && now <= officeClosed){
        true
    }
    else{
        false
    }

    println("Office is open: $isOpen")

    // or
    var isClose: Boolean= now  < officeOpen || now > officeClosed

    println("Office is CLosed: $isClose")

    // Not
    var isOpen1: Boolean = now > officeOpen

    if(!isOpen1){
        println("Office is Closed")
    }
    else{
        println("Office is Open")
    }
}
