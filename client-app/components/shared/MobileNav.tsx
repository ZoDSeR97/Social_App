"use client"

import { navigationLinks, getIconComponent } from "./NavigationLinks";
import Link from "next/link";
import { usePathname, useRouter } from "next/navigation";

export const MobileNav = () => {
    const router = useRouter();
    const path = usePathname();
    
    return (
        <section className="bottombar">
            <div className="bottombar_container">
                {navigationLinks.map((link) => {
                    const isActive = path.includes(link.route) && link.route.length > 1 || path === link.route;
                    return (
                        <Link href={link.route} key={link.label} className={`bottombar_link ${isActive ? "bg-primary-500" : ""}`}>
                            {getIconComponent(link.imgURL)}
                            <p className="text-subtle-medium text-light-1 max-sm:hidden">
                                {link.label.split(/\s+/)[0]}
                            </p>
                        </Link>
                    )
                })
                }
            </div>
        </section>
    )
}