//
//  Victoire.swift
//  qvgdm1
//
//  Created by Thomas JAULGEY on 23/05/2020.
//  Copyright © 2020 Thomas JAULGEY. All rights reserved.
//

import Cocoa

class win: NSViewController {
    
    @IBOutlet weak var quitter: NSButton!
    
    @IBAction func closeall(_ sender: Any) {
        exit(0)
    }
    
    override func viewDidLoad() {
        super.viewDidLoad()

        // Do any additional setup after loading the view.
    }

    override var representedObject: Any? {
        didSet {
        // Update the view, if already loaded.
        }
    }


}
