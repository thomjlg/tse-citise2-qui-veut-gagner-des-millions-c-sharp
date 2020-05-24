//
//  AppDelegate.swift
//  qvgdm1
//
//  Created by Thomas JAULGEY on 22/05/2020.
//  Copyright © 2020 Thomas JAULGEY. All rights reserved.
//

import Cocoa
import Foundation



//import PGSQLKit
//
//var connectionString: String
//connectionString = "host=" + "localhost"
//connectionString += " port=" + "5432"
//connectionString += " dbname=" + "qvgdm"
//connectionString += " user=" + "thomas"
//connectionString += " password=" + "thomas"
//
//var conn: PGSQLConnection
//conn = PGSQLConnection();
//
//conn.ConnectionString = connectionString
//if (conn.connect())
//{
//    var rs = conn.open("select 'Hello Detabase!' as hello")
//    while (!rs!.IsEOF)
//    {
//        var hello = rs!.fieldByName("hello").asString()
//        println("Database says:  \(hello)")
//        rs!.moveNext()
//    }
//    rs!.close()
//    conn.close();
//}


@NSApplicationMain
class AppDelegate: NSObject, NSApplicationDelegate {
    
    func applicationDidFinishLaunching(_ aNotification: Notification) {
        // Insert code here to initialize your application
    }

    func applicationWillTerminate(_ aNotification: Notification) {
        // Insert code here to tear down your application
    }


}

