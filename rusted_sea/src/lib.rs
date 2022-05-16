#[no_mangle]
pub extern fn add_numbers(arg1: i32, arg2: i32) -> i32 {
    print!("Rust says: add_numbers({}, {})\n", arg1, arg2);
    arg1 + arg2
}

#[repr(C)]
pub struct ExampleStruct {
    pub x: i32,
    pub y: i32,
}

#[no_mangle]
pub extern fn get_example_struct() -> ExampleStruct {
    print!("Rust says: get_example_struct()\n");
    ExampleStruct { x: 1, y: 2 }
}

#[cfg(test)]
mod tests {
    use crate::add_numbers;

    #[test]
    fn it_works() {
        let result: i32 = add_numbers(2, 2);
        assert_eq!(result, 4);
    }
}
