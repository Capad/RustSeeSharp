#[no_mangle]
pub extern fn add_numbers(arg1: i32, arg2: i32) -> i32 {
    arg1 + arg2
}

#[repr(C)]
pub struct ExampleStruct {
    pub x: i32,
    pub y: i32,
}

#[no_mangle]
pub extern fn get_example_struct() -> ExampleStruct {
    ExampleStruct { x: 1, y: 2 }
}

#[no_mangle]
pub extern fn get_opposite_bool(condition: bool) -> bool {
    !condition
}

#[cfg(test)]
mod tests {
    use crate::{add_numbers, get_opposite_bool};

    #[test]
    fn add_numbers_test() {
        let result: i32 = add_numbers(2, 2);
        assert_eq!(result, 4);
    }
    
    #[test]
    fn get_bool_true_test() {
        let result: bool = get_opposite_bool(true);
        assert_eq!(result, false);
    }

    #[test]
    fn get_bool_false_test() {
        let result: bool = get_opposite_bool(false);
        assert_eq!(result, true);
    }
}
