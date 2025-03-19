﻿namespace StudentReactWebApIDemo.Models
{
    public class StudentDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public IFormFile? ImageFile { get; set; }
    }
}
