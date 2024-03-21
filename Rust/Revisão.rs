fn main() {
    println!("Hello, word!");

    let total = 10;
    let _total = 20;

    println!("{}", total);
    println!("{}", _total);

    let number01 = 01;
    let number02 = 02;

    println!("{}", number01 + number02);

    let mut number03 = 03;
    println!("{}", number03);

    number03 = 04;
    println!("{}", number03);

    let n0 = 1;
    println!("{}", n0);

    let n0 = "Um";
    println!("{}", n0);



    let n1 = 0;
    println!("{}", n1);
    {
        let n1 = 1;
        println!("{}", n1);
    }
    println!("{}", n1);


    let variavel001 = 0;
    println!("{}", variavel001);

    let variavel001 : i32 = 0;
    println!("{}", variavel001);

    let xx= 100_000_000_0;
    println!("{}", xx);

    const SEGUNDOS_MINUTOS : u32 = 60;
    let nn01 = 1;
    println!("{}", nn01 * SEGUNDOS_MINUTOS);
}
