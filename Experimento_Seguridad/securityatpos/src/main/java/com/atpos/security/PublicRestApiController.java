package com.atpos.security;

import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("api/public")
@CrossOrigin
public class PublicRestApiController {
    private UserRepository userRepository;
    private InvoiceRepository invoiceRepository;

    public PublicRestApiController(UserRepository userRepository, InvoiceRepository invoiceRepository) {
        this.userRepository = userRepository;
        this.invoiceRepository = invoiceRepository;
    }

    // Available to all authenticated users
    @GetMapping("test")
    public String test1() {
        return "API Test";
    }

    // Available to managers
    @GetMapping("proveedor/invoices")
    public List<Invoice> reports() {
        return this.invoiceRepository.findAll();
    }

    // Available to ROLE_ADMIN
    @GetMapping("admin/users")
    public List<User> users() {
        return this.userRepository.findAll();
    }
}