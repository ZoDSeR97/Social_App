import Link from "next/link";
import Image from "next/image";
import { SignedIn, SignOutButton, UserButton } from "@clerk/nextjs";
import { getIconComponent } from "./Utilities";

export const Nav = () => {
    return (
        <nav className="topbar">
            <Link href="/" className="flex items-center gap-1">
                <Image src="/logo.svg" alt="logo" width={40} height={40} className="App-logo"/>
                <h1 className="text-heading3-bold text-light-1 max-xs:hidden">Social App</h1>
            </Link>
            <div className="flex items-center gap-1">
                <div className="block lg:hidden">
                    <SignedIn>
                        <UserButton />
                    </SignedIn>
                </div>
            </div>
        </nav>
    )
}