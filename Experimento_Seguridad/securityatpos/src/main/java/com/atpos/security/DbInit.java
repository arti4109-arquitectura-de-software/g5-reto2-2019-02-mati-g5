package com.atpos.security;

import org.springframework.boot.CommandLineRunner;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import java.util.Arrays;
import java.util.List;

@Service
public class DbInit implements CommandLineRunner {
    private UserRepository userRepository;
    private InvoiceRepository invoiceRepository;
    private PasswordEncoder passwordEncoder;

    public DbInit(UserRepository userRepository, PasswordEncoder passwordEncoder,InvoiceRepository invoiceRepository ) {
        this.userRepository = userRepository;
        this.passwordEncoder = passwordEncoder;
        this.invoiceRepository = invoiceRepository;
    }

    @Override
    public void run(String... args) {
        // Delete all
        this.userRepository.deleteAll();

        // Crete users
        User dan = new User("caja",passwordEncoder.encode("caja123"),"USER","");
        User admin = new User("admin",passwordEncoder.encode("admin123"),"ADMIN","ACCESS_TEST1,ACCESS_TEST2");
        User manager = new User("proveedor",passwordEncoder.encode("proveedor123"),"PROVEEDOR","ACCESS_TEST1");

        List<User> users = Arrays.asList(dan,admin,manager);

        Invoice invone = new Invoice("clienteuno","productouno",Double.parseDouble("100000"),10,Double.parseDouble("1000"));
        Invoice invtwo = new Invoice("clienteuno","productotwo",Double.parseDouble("100000"),10,Double.parseDouble("1000"));
        Invoice invthree = new Invoice("clienteuno","productothree",Double.parseDouble("100000"),10,Double.parseDouble("1000"));
        Invoice invfour = new Invoice("clienteuno","productofour",Double.parseDouble("100000"),10,Double.parseDouble("1000"));
        Invoice invfive = new Invoice("clienteuno","productofive",Double.parseDouble("100000"),10,Double.parseDouble("1000"));

        List<Invoice> invoices = Arrays.asList(invone,invtwo,invthree,invfour,invfive);
        // Save to db
        this.userRepository.saveAll(users);
        this.invoiceRepository.saveAll(invoices);
    }
}
